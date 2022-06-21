using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuLuzNet.Clases;
using System.Windows.Forms;

namespace TuLuzNet.Negocio
{
    class Ne_Clientes
    {
        BD_acceso_a_datos _BD_clientes = new BD_acceso_a_datos();

        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public string CUIT { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string activo { get; set; }

        public DataTable RecuperarTodosClientes()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente]";
            return _BD_clientes.EjecutarSQL(sql);
        }

        public EstructuraCombo DatosComboCuit()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "cuitCliente";
            Ec.Value = "cuitCliente";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Cliente]";
            Ec.Tabla = _BD_clientes.EjecutarSQL(Ec.Sql);
            return Ec;
        }

        public void RecargarCliente(Control.ControlCollection Controles, DataTable tabla)
        {
            foreach (var item in Controles)
            {
                string TipoControl = item.GetType().Name;
                if (TipoControl == "TextBox01")
                {
                    TextBox01 txt = item as TextBox01;
                    if (txt._columna == "nombreCliente" || txt._columna == "apellidoCliente")
                        txt.Text = _TE.BuscarDato(tabla, txt._columna);
                }
            }
        }

        public DataTable RecuperarClientesXActivo(int estado)
        {
            string sql = @"SELECT cuitCliente, nombreCliente, apellidoCliente FROM [BD3K6G02_2022].[dbo].[Cliente] WHERE activo = " + estado.ToString();
            return _BD_clientes.EjecutarSQL(sql);
        }
        public DataTable RecuperarTodosClientesXActivo(int estado)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente] WHERE activo = " + estado.ToString();
            return _BD_clientes.EjecutarSQL(sql);
        }
        public DataTable RecuperarClienteXNombre(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente] WHERE nombre LIKE '%" + nombre + "%'";
            return _BD_clientes.EjecutarSQL(sql);
        }
        public DataTable RecuperarClienteXApellido(string apellido)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente] WHERE apellido LIKE '%" + apellido + "%'";
            return _BD_clientes.EjecutarSQL(sql);
        }
        public DataTable RecuperaPedidoXCliente(string cuitCliente)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente] WHERE cuitCliente LIKE '%" + cuitCliente + "%'";
            return _BD_clientes.EjecutarSQL(sql);
        }
        public DataTable RecuperarCantClientesActivos()
        {
            string sql = @"SELECT activo, count(*) as Cantidad FROM [BD3K6G02_2022].[dbo].[Cliente] GROUP BY activo";
            return _BD_clientes.EjecutarSQL(sql);
        }

        public void AltaCliente(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "Cliente");
            if (sql != "")
            {
                _BD_clientes.Insertar(sql);
                MessageBox.Show("Se cargó el Cliente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se cargó el Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Modificar()
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Cliente] SET cuitCliente = '20431412528', nombre = 'Danieeel', 
            //    apellido = 'Maldonado', activo = '1' WHERE cuitCliente = '20431412528';
            string sql = "UPDATE[BD3K6G02_2022].[dbo].[Cliente] SET ";
            sql += "cuitCliente = " + _TE.DatosTexto(this.CUIT);
            sql += ", nombre = " + _TE.DatosTexto(this.nombre);
            sql += ", apellido = " + _TE.DatosTexto(this.apellido);
            sql += ", activo = " + this.activo;
            sql += " WHERE cuitCliente = " + _TE.DatosTexto(this.CUIT);

            if (_BD_clientes.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error");
            }
        }

        public void Borrar(string CUIT)
        {
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[Cliente] WHERE cuitCliente = '" + CUIT + "'";
            if (_BD_clientes.Borrar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se borro existosamente");
            }
            else
            {
                MessageBox.Show("No se borro, hubo error");
            }
        }
        public EstructuraCombo DatosCombo()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "cuitCliente";
            Ec.Value = "cuitCliente";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Cliente]";
            Ec.Tabla = _BD_clientes.EjecutarSQL(Ec.Sql);
            return Ec;
        }
    }
}
