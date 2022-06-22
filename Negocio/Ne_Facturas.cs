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
    public class Ne_Facturas
    {
        BD_acceso_a_datos _BD_Facturas = new BD_acceso_a_datos();

        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public int numeroFactura { get; set; }

        public int numeroDetFactura { get; set; }
        public DateTime fecha { get; set; }
        public string tipoFactura { get; set; }
        public int numDocEmpleado { get; set; }
        public string cuil { get; set; }
        public int activo { get; set; }

        public DataTable RecuperarFacturas()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Factura]";
            return _BD_Facturas.EjecutarSQL(sql);
        }       
        
        public DataTable RecuperarFacturasXNumFactura(int numFactura)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Factura] WHERE numeroFactura = " + numFactura;
            return _BD_Facturas.EjecutarSQL(sql);
        }
        public int RecuperarFacturasXNumFactura1(int numFactura)
        {
            DataTable rtdo = new DataTable();
            int numero;
            string sql = @"SELECT numeroDetalleFactura FROM [BD3K6G02_2022].[dbo].[DetalleFactura] WHERE numFactura = " + numFactura;
            rtdo = _BD_Facturas.EjecutarSQL(sql);
            numero = Int32.Parse(BuscarDato(rtdo, "numeroDetalleFactura"));
            return numero;
        }
        public DataTable RecuperarDetallesFac(int numero)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[DetalleFactura] WHERE numFactura = " + numero;
            return _BD_Facturas.EjecutarSQL(sql);
        }
        public DataTable RecuperarDetallesFac1(int numero)
        {
            string sql = "SELECT codProducto as Producto, cantidad as Cant, precioUnitario FROM [BD3K6G02_2022].[dbo].[DetalleFactura] " +
                            "WHERE numFactura = " + numero;
            return _BD_Facturas.EjecutarSQL(sql);
        }
        public DataTable RecuperarFacturasXActivo(bool activo)
        {
            int activoFactura = activo ? 1 : 0;
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Factura] WHERE activo = " + activoFactura;
            return _BD_Facturas.EjecutarSQL(sql);
        }

        public void AltaFacturas(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "Factura");
            if (sql != "")
            {
                _BD_Facturas.Insertar(sql);
                MessageBox.Show("Se cargó la Factura.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se cargó la Factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        internal void Grabar(DataGridView grilla)
        {
            string sql = "INSERT [BD3K6G02_2022].[dbo].[Factura] (numeroFactura, fecha, tipoFactura, numDocEmpleado, cuilCuit, activo) VALUES (";
            sql += this.numeroFactura + ", ";
            sql += "CONVERT (date, '" + this.fecha.ToShortDateString() + "', 103)" + ", '";
            sql += this.tipoFactura + "', ";
            sql += this.numDocEmpleado + ", ";
            sql += this.cuil + ", ";
            sql += this.activo + "";
            sql += "); ";
            foreach (DataGridViewRow fila in grilla.Rows)
            {
                sql += "INSERT [BD3K6G02_2022].[dbo].[DetalleFactura] (numeroDetalleFactura, numFactura,codProducto, cantidad, precioUnitario) VALUES (";
                sql += this.numeroDetFactura +",";
                sql += this.numeroFactura;
                sql += ", " + fila.Cells[0].Value;
                sql += ", " + fila.Cells[1].Value;
                sql += ", " + fila.Cells[2].Value.ToString().Replace(",", ".") + "); ";
            }

            if (_BD_Facturas.Insertar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se grabo correctamente");
            }
            else
            {
                MessageBox.Show("No se grabo, hubo error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Modificar(DataGridView grilla)
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Cliente] SET cuitCliente = '20431412528', nombre = 'Danieeel', 
            //    apellido = 'Maldonado', activo = '1' WHERE cuitCliente = '20431412528';
            string sql = "UPDATE [BD3K6G02_2022].[dbo].[Factura] SET ";
            sql += "numeroFactura = " + this.numeroFactura;
            sql += ", fecha = CONVERT (date, '" + this.fecha.ToShortDateString() + "', 103)";
            sql += ",tipoFactura = '" + this.tipoFactura;
            sql += "' , numDocEmpleado = " + this.numDocEmpleado;
            sql += ", cuilCuit = " + this.cuil;
            sql += ", activo = " + this.activo;  
            sql += " WHERE numeroFactura = " + this.numeroFactura + "; ";
            foreach (DataGridViewRow fila in grilla.Rows)
            {
                sql += "INSERT [BD3K6G02_2022].[dbo].[DetalleFactura] (numeroDetalleFactura, numFactura,codProducto, cantidad, precioUnitario) VALUES (";
                sql += this.numeroDetFactura + ",";
                sql += this.numeroFactura;
                sql += ", " + fila.Cells[0].Value;
                sql += ", " + fila.Cells[1].Value;
                sql += ", " + fila.Cells[2].Value.ToString().Replace(",", ".") + "); ";
            }

            if (_BD_Facturas.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Borrar(string numFactura)
        {
            string SqlBorrar = "DELETE FROM [BD3K6G02_2022].[dbo].[DetalleFactura] WHERE numFactura = " + numFactura + "; ";
            SqlBorrar += "DELETE FROM [BD3K6G02_2022].[dbo].[Factura] WHERE numeroFactura = " + numFactura + "; ";
            if (_BD_Facturas.Borrar(SqlBorrar) == BD_acceso_a_datos.TipoEstado.correcto)
                MessageBox.Show("Se borró exitosamente");
            else
                MessageBox.Show("No se borró, hubo error");
        }

        public int obtenerNumDetFactura()
        {
            int numero = 1;
            try
            {
                DataTable rtdo = new DataTable();
                //SELECT MAX(numeroDetalleFactura) as numeroDetalleFactura FROM[BD3K6G02_2022].[dbo].[DetalleFactura]
                string sql = "SELECT MAX(numeroDetalleFactura) as numeroDetalleFactura FROM [BD3K6G02_2022].[dbo].[DetalleFactura]";
                rtdo = _BD_Facturas.EjecutarSQL(sql);
                numero = Int32.Parse(BuscarDato(rtdo, "numeroDetalleFactura"));
            }
            catch
            {
                return numero;
            }
            return numero + 1;
        }

        public int obtenerNumFactura()
        {
            int numero = 1;
            try
            {
                DataTable rtdo = new DataTable();
                //SELECT MAX(numeroFactura) as numeroFactura FROM[BD3K6G02_2022].[dbo].[Factura]
                string sql = "SELECT MAX(numeroFactura) as numeroFactura FROM [BD3K6G02_2022].[dbo].[Factura]";
                rtdo = _BD_Facturas.EjecutarSQL(sql);
                numero = Int32.Parse(BuscarDato(rtdo, "numeroFactura"));
            }
            catch
            {
                return numero;
            }
            return numero + 1;
        }

        public double PrecioProducto(string producto)
        {
            DataTable rtdo = new DataTable();
            string sql = "SELECT precio FROM [BD3K6G02_2022].[dbo].[Productos] " +
                            "WHERE codProducto = " + producto;
            rtdo = _BD_Facturas.EjecutarSQL(sql);
            return Convert.ToDouble(BuscarDato(rtdo, "precio"));
        }

        public void Modificar()
        {
            string sql = "UPDATE[BD3K6G02_2022].[dbo].[Factura] SET ";
            sql += "fecha = '" + this.fecha.Year + this.fecha.Month + this.fecha.Day + "'";
            sql += ", tipoFactura = " + _TE.DatosTexto(this.tipoFactura.ToString());
            sql += ", numDocEmpleado = " + _TE.DatosTexto(this.numDocEmpleado.ToString());
            sql += ", cuil = " + _TE.DatosTexto(this.cuil);
            sql += ", activo = " + this.activo;
            sql += " WHERE codFactura = " + this.numeroFactura;

            if (_BD_Facturas.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error");
            }
        }

        public void BorrarLogico(string idFactura)
        {
            string sql = "UPDATE[BD3K6G02_2022].[dbo].[Factura] SET activo = 0 WHERE numeroFactura = " + idFactura;
            if (_BD_Facturas.Borrar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se borró existosamente");
            }
            else
            {
                MessageBox.Show("No se borro, hubo error");
            }
        }
    }
}
