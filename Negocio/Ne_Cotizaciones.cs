using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.Clases;

namespace TuLuzNet.Negocio
{
    public class Ne_Cotizaciones
    {
        public int numeroCotizacion { get; set; }
        public int año { get; set; }
        public string cuitCliente { get; set; }
        public int tipoDocEmpleado { get; set; }
        public int numDocEmpleado { get; set; }
        public int codEstado { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public DateTime dtpFecha { get; set; }
        public string observaciones { get; set; }
        public float precioTotal { get; set; }
        public string motivoPerdida { get; set; }

        

        public string nombreCompetidor { get; set; }

        BD_acceso_a_datos _BD_cotizaciones = new BD_acceso_a_datos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public EstructuraCombo DatosCombo() // para Estados
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "descripcion";
            Ec.Value = "codEstado";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[EstadosCotizaciones]";
            Ec.Tabla = _BD_cotizaciones.EjecutarSQL(Ec.Sql);
            return Ec;
        }
        public DataTable RecuperarCotizaciones()
        {
            string sql = "SELECT * FROM [BD3K6G02_2022].[dbo].[Cotizaciones]";
            return _BD_cotizaciones.EjecutarSQL(sql);
        }
        public DataTable RecuperarDetallesCot(string numero, string año)
        {
            string sql = "SELECT codProducto as Producto, cantidad as Cant, Precio FROM [BD3K6G02_2022].[dbo].[DetalleCotizacion] " +
                            "WHERE numeroCotizacion = " + numero + " AND año = " + año;
            return _BD_cotizaciones.EjecutarSQL(sql);
        }
        public DataTable RecuperarCantCotz()
        {
            string sql = "SELECT c.codEstadoCotizacion, e.descripcion, COUNT(*) as cantidad FROM [BD3K6G02_2022].[dbo].[Cotizaciones] c JOIN [BD3K6G02_2022].[dbo].[EstadosCotizaciones] e ON (c.codEstadoCotizacion=e.codEstado) " +
                            "GROUP BY c.codEstadoCotizacion, e.descripcion";
            return _BD_cotizaciones.EjecutarSQL(sql);
        }
        public DataTable RecuperarCotizaciones(string numero = "", string año = "", string cuitCliente = "", int estado = -1)
        {
            System.Data.DataTable rtdo = new DataTable();
            try
            {
                string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cotizaciones]
                               WHERE numeroCotizacion = '" + numero + "' or año = '" + año + "' or cuitCliente = '" + cuitCliente + "' or codEstadoCotizacion = '" + estado + "'";
                rtdo = _BD_cotizaciones.EjecutarSQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtdo;
        }
        public DataTable BuscarCotXVendedor(string docVend)
        {
            DataTable rtdo = new DataTable();
            try
            {
                string sql = @"SELECT c.numeroCotizacion, c.cuitCliente, e.descripcion, c.fecha, c.precioTotal
                               FROM [BD3K6G02_2022].[dbo].[Cotizaciones] c join [BD3K6G02_2022].[dbo].[EstadosCotizaciones] e on (c.codEstadoCotizacion=e.codEstado)
                               WHERE numDocVendedor = '" + docVend + "'";
                rtdo = _BD_cotizaciones.EjecutarSQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtdo;
        }
        public DataTable RecuperarClienteXCuit(string cuitCliente)
        {
            DataTable rtdo = new DataTable();
            try
            {
                string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente]
                                       WHERE cuitCliente = '" + cuitCliente + "'";
                rtdo = _BD_cotizaciones.EjecutarSQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtdo;
        }
        public DataTable RecuperarCotizacionXNum(string numero)
        {
            string sql = "SELECT * FROM [BD3K6G02_2022].[dbo].[Cotizaciones] WHERE numeroCotizacion = '" + numero + "'";
            return _BD_cotizaciones.EjecutarSQL(sql);
        }        
        
        public DataTable RecuperarCotizacionXPrecio(string min, string max)
        {
            string sql = "SELECT C.[numeroCotizacion],C.[año],C.[cuitCliente],C.[numDocVendedor],EC.[descripcion],C.[nombreCliente],C.[apellidoCliente],C.[fecha],C.[observaciones],C.[precioTotal],C.[motivoPerdida] FROM [BD3K6G02_2022].[dbo].[Cotizaciones] C JOIN EstadosCotizaciones EC ON C.codEstadoCotizacion = EC.codEstado WHERE C.precioTotal BETWEEN " + min + " AND " + max;
            return _BD_cotizaciones.EjecutarSQL(sql);
        }

        public void RecargarCliente(Control.ControlCollection Controles, DataTable Tabla)
        {
            foreach (var item in Controles)
            {
                string TipoControl = item.GetType().Name;
                if (TipoControl == "TextBox01")
                {
                    TextBox01 txt = item as TextBox01;
                    if (txt._columna == "nombreCliente" || txt._columna == "apellidoCliente")
                        txt.Text = BuscarDato(Tabla, txt._columna);
                    else // no tendria q entrar aca nunca
                    {
                        //string rtdo = BuscarDato(Tabla, txt._columna);
                        //if (rtdo != "")
                        //    txt.Text = rtdo;
                    }
                }
            }
        }
        private string BuscarDato(DataTable Tabla, String Columna)
        {
            for (int i = 0; i < Tabla.Columns.Count; i++)
            {
                if (Tabla.Columns[i].Caption.ToUpper() == Columna.Trim().ToUpper())
                {
                    return Tabla.Rows[0][i].ToString();
                }
            }
            return "";
        }
        public void CalcularTotal(string numero, string año, Control.ControlCollection Controles) //no sabía como usar los datos de la grilla así q uso sql para saber el total
        {
            DataTable rtdo = new DataTable();
            string sql = "SELECT SUM(cantidad * Precio) as precioTotal FROM [BD3K6G02_2022].[dbo].[DetalleCotizacion] " +
                            "WHERE numeroCotizacion = " + numero + " AND año = " + año;
            rtdo = _BD_cotizaciones.EjecutarSQL(sql);

            foreach (var item in Controles)
            {
                string TipoControl = item.GetType().Name;
                if (TipoControl == "TextBox01")
                {
                    TextBox01 txt = item as TextBox01;
                    if (txt._columna == "precioTotal")
                        txt.Text = BuscarDato(rtdo, txt._columna);
                }
            }
        }
        public double PrecioProducto(string producto)
        {
            DataTable rtdo = new DataTable();
            string sql = "SELECT precio FROM [BD3K6G02_2022].[dbo].[Productos] " +
                            "WHERE codProducto = " + producto;
            rtdo = _BD_cotizaciones.EjecutarSQL(sql);
            return Convert.ToDouble(BuscarDato(rtdo, "precio"));
        }

        public void BorrarCotizacion(string numero, string año)
        {
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[Cotizaciones] WHERE numeroCotizacion = " + numero + " AND año = " + año + ";"; //borramos todos los productos de esa cotizacion
            _BD_cotizaciones.EjecutarSQL(sql);
            return;
        }
        public void BorrarDetalles(string numero, string año)
        {
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[DetalleCotizacion] WHERE numeroCotizacion = " + numero + " AND año = " + año + ";"; //borramos todos los productos de esa cotizacion
            _BD_cotizaciones.EjecutarSQL(sql);
            return;
        }
        public void Modificar(DataGridView grilla)
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Cliente] SET cuitCliente = '20431412528', nombre = 'Danieeel', 
            //    apellido = 'Maldonado', activo = '1' WHERE cuitCliente = '20431412528';
            string sql = "UPDATE [BD3K6G02_2022].[dbo].[Cotizaciones] SET ";
            //sql += "numeroCotizacion = " + this.numeroCotizacion;
            sql += "año = " + this.año;
            sql += ", cuitCliente = " + this.cuitCliente;
            sql += ", tipoDocVendedor = " + this.tipoDocEmpleado;
            sql += ", numDocVendedor = " + this.numDocEmpleado;
            sql += ", codEstadoCotizacion = " + this.codEstado;
            sql += ", nombreCliente = " + _TE.DatosTexto(this.nombreCliente);
            sql += ", apellidoCliente = " + _TE.DatosTexto(this.apellidoCliente);
            sql += ", fecha = CONVERT (date, '" + this.dtpFecha + "', 103)";
            sql += ", observaciones = " + _TE.DatosTexto(this.observaciones);
            sql += ", precioTotal = " + this.precioTotal.ToString().Replace(",",".");
            if (this.motivoPerdida != "")
            {
                sql += ", motivoPerdida = " + _TE.DatosTexto(this.motivoPerdida);
                sql += ", nomCompetidor = " + _TE.DatosTexto(this.nombreCompetidor);
            }
            sql += " WHERE numeroCotizacion = " + this.numeroCotizacion + "; ";

            foreach (DataGridViewRow fila in grilla.Rows)
            {
                sql += "INSERT [BD3K6G02_2022].[dbo].[DetalleCotizacion] (numeroCotizacion, año, codProducto, cantidad, Precio) VALUES (";
                sql +=  this.numeroCotizacion;
                sql += ", " + this.año;
                sql += ", " + fila.Cells[0].Value;
                sql += ", " + fila.Cells[1].Value;
                sql += ", " + fila.Cells[2].Value.ToString().Replace(",",".") + "); ";
            }
            
            if (_BD_cotizaciones.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Grabar(DataGridView grilla)
        {
            {
                string sql = "";
                if (this.motivoPerdida != "" && this.codEstado != -4)
                {
                    sql += "INSERT [BD3K6G02_2022].[dbo].[Cotizaciones] (numeroCotizacion, año, cuitCliente, tipoDocVendedor, numDocVendedor, codEstadoCotizacion, nombreCliente, apellidoCliente, fecha, observaciones, precioTotal, motivoPerdida, nomCompetidor) VALUES (";
                }
                else
                {
                    sql += "INSERT [BD3K6G02_2022].[dbo].[Cotizaciones] (numeroCotizacion, año, cuitCliente, tipoDocVendedor, numDocVendedor, codEstadoCotizacion, nombreCliente, apellidoCliente, fecha, observaciones, precioTotal) VALUES (";
                }

                sql += this.numeroCotizacion + ", ";
                sql += this.año + ", ";
                sql += this.cuitCliente + ", ";
                sql += this.tipoDocEmpleado + ", ";
                sql += this.numDocEmpleado + ", ";
                sql += this.codEstado + ", ";
                sql += _TE.DatosTexto(this.nombreCliente) + ", ";
                sql += _TE.DatosTexto(this.apellidoCliente) + ", ";
                sql += "CONVERT (date, '" + this.dtpFecha + "', 103)" + ", ";
                sql += _TE.DatosTexto(this.observaciones) + ", ";
                sql += this.precioTotal.ToString().Replace(",", ".");
                if (this.motivoPerdida != "" && this.codEstado != -4)
                {
                    sql += ", " + _TE.DatosTexto(this.motivoPerdida);
                    sql += ", " + _TE.DatosTexto(this.nombreCompetidor);
                }
                sql += "); ";

                foreach (DataGridViewRow fila in grilla.Rows)
                {
                    sql += "INSERT [BD3K6G02_2022].[dbo].[DetalleCotizacion] (numeroCotizacion, año, codProducto, cantidad, Precio) VALUES (";
                    sql += this.numeroCotizacion;
                    sql += ", " + this.año;
                    sql += ", " + fila.Cells[0].Value;
                    sql += ", " + fila.Cells[1].Value;
                    sql += ", " + fila.Cells[2].Value.ToString().Replace(",", ".") + "); ";
                }

                if (_BD_cotizaciones.Insertar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
                {
                    MessageBox.Show("Se modifico correctamente");
                }
                else
                {
                    MessageBox.Show("No se modifico, hubo error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int obtenerNumero()
        {
            int numero = 1;
            try
            {
                DataTable rtdo = new DataTable();
                string sql = "SELECT MAX(numeroCotizacion) as numeroCotizacion FROM [BD3K6G02_2022].[dbo].[Cotizaciones] ";
                rtdo = _BD_cotizaciones.EjecutarSQL(sql);
                numero = Int32.Parse(BuscarDato(rtdo, "numeroCotizacion"));
            }
            catch
            {
                return numero;
            }
            return numero+1;
        }
    }
}
