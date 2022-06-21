using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuLuzNet.Clases;
using System.Data;
using System.Windows.Forms;

namespace TuLuzNet.Negocio
{
    public class Ne_Productos
    {
        public int codProducto { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public int cantStock { get; set; }

        //public int cuitProveedor { get; set; }
        public Int64 cuitProveedor { get; set; }
        public string descripcion { get; set; }
        public int codProductoEquivalente { get; set; }

        BD_acceso_a_datos _BD_Productos = new BD_acceso_a_datos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();


        public DataTable RecuperarProductoXcodProducto(int codProducto)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Productos] WHERE codProducto LIKE '%" + codProducto + "%'";
            return _BD_Productos.EjecutarSQL(sql);
        }
        public DataTable RecuperarProductoXNombre(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Productos] WHERE nombre LIKE '%" + nombre + "%'";
            return _BD_Productos.EjecutarSQL(sql);
        }

        public DataTable RecuperarProductosXAño(string año)
        {
            string sql = @"SELECT DP.codigoProducto, DP.cantidad, PR.nombre, P.añoCotizacion FROM Pedidos P JOIN DetallePedido DP ON DP.numeroPedido = P.numeroPedido JOIN Productos PR ON PR.codProducto = DP.codigoProducto WHERE P.añoCotizacion = " + año;
            return _BD_Productos.EjecutarSQL(sql);
        }

        public DataTable RecuperarProductos() //Todos los productos
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Productos]";
            return _BD_Productos.EjecutarSQL(sql);
        }

        public DataTable RecuperarProductos(string nombre = "", string codProducto = "") // Los productos por parametro
        {
            System.Data.DataTable rtdo = new DataTable();
            try
            {
                string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Productos] 
                        WHERE nombre LIKE '" + nombre + "' or codProducto LIKE '" + codProducto + "';";
                rtdo = _BD_Productos.EjecutarSQL(sql);

            }

            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtdo;
        }

        public void AltaProducto(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "Productos");
            if (sql != "")
            {
                _BD_Productos.Insertar(sql);
                MessageBox.Show("Se cargó el Producto.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se cargó el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Modificar()
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Productos] SET nombre = 'abcd', precio = 3, cantStock = 99 ,
            //descripcion = 'ej', cuitProveedor = 30110014898 ,codProductoEquivalente = 1  WHERE codProducto = 15;
            string sql = "UPDATE[BD3K6G02_2022].[dbo].[Productos] SET ";
            sql += "nombre = " + _TE.DatosTexto(this.nombre);
            sql += ", precio = " + this.precio;
            sql += ", cantStock = " + this.cantStock;
            sql += ", descripcion = " + _TE.DatosTexto(this.descripcion);
            sql += ", cuitProveedor = " + this.cuitProveedor;
            sql += ", codProductoEquivalente = " + this.codProductoEquivalente;
            sql += " WHERE codProducto = " + this.codProducto;

            if (_BD_Productos.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error");
            }
        }

        public void Borrar(string codProducto)
        {
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[Productos] WHERE codProducto = " + codProducto;
            if (_BD_Productos.Borrar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
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
            Ec.Display = "razonSocial";
            Ec.Value = "cuitProveedor";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Proveedor]";
            Ec.Tabla = _BD_Productos.EjecutarSQL(Ec.Sql);
            return Ec;
        }

        public EstructuraCombo DatosCombo1()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "nombre";
            Ec.Value = "codProducto";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Productos] WHERE esGenerico = 0";
            Ec.Tabla = _BD_Productos.EjecutarSQL(Ec.Sql);
            return Ec;
        }
    }

}
