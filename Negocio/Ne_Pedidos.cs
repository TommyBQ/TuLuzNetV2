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
    class Ne_Pedidos
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public int numPedido { get; set; }
        public int numCotizacion { get; set; }
        public int añoCotizacion { get; set; }
        public int tipoDocVendedor { get; set; }
        public int numDocVendedor { get; set; }
        public string condicionPago { get; set; }
        public string cuitCliente { get; set; }
        public DateTime dtpFecha { get; set; }

        
        BD_acceso_a_datos _BD_Pedidos = new BD_acceso_a_datos();
        TratamientosEspeciales _TE1 = new TratamientosEspeciales();

        public EstructuraCombo DatosCombo()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "siglas";
            Ec.Value = "idTipoDoc";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[TipoDocumento]";
            Ec.Tabla = _BD_Pedidos.EjecutarSQL(Ec.Sql);
            return Ec;
        }

        public DataTable RecuperarPedidosXMes()
        {
            string sql = "SELECT CASE MONTH(fechaPedido) WHEN 1 THEN 'Enero' WHEN 2 THEN 'Febrero' WHEN 3 THEN 'Marzo' WHEN 4 THEN 'Abril' WHEN 5 THEN 'Mayo' WHEN 6 THEN 'Junio' WHEN 7 THEN 'Julio' WHEN 8 THEN 'Agosto' WHEN 9 THEN 'Septiembre' WHEN 10 THEN 'Octubre' WHEN 11 THEN 'Noviembre' WHEN 12 THEN 'Diciembre'  END AS Mes, COUNT(MONTH(fechaPedido)) as cantidad FROM Pedidos WHERE YEAR(fechaPedido) = 2022 group by MONTH(fechaPedido)";
            return _BD_Pedidos.EjecutarSQL(sql);
        }

        public DataTable RecuperarPedidoEntrePrecio(string min, string max)
        {
            string sql = "SELECT P.numeroPedido, C.nombreCliente, C.apellidoCliente, C.cuitCliente, P.fechaPedido, P.numDniVendedor, P.condicionPago, DP.precio From Pedidos P JOIN Cliente C ON P.cuitCliente = C.cuitCliente JOIN DetallePedido DP ON DP.numeroPedido = P.numeroPedido WHERE DP.precio BETWEEN " + min + " AND " + max;
            return _BD_Pedidos.EjecutarSQL(sql);
        }

        internal object obtenerNumero()
        {
            int numero = 1;
            try
            {
                DataTable rtdo = new DataTable();
                string sql = "SELECT MAX(numeroPedido) as numeroPedido FROM [BD3K6G02_2022].[dbo].[Pedidos] ";
                rtdo = _BD_Pedidos.EjecutarSQL(sql);
                numero = Int32.Parse(_TE1.BuscarDato(rtdo, "numeroPedido"));
            }
            catch
            {
                return numero;
            }
            return numero + 1;
        }

        public DataTable RecuperarPedidoXCliente(string cuit)
        {
            string sql = "SELECT numeroPedido, fechaPedido, numDniVendedor, condicionPago FROM [BD3K6G02_2022].[dbo].[Pedidos] WHERE cuitCliente = " + cuit;
            DataTable rtdo = _BD_Pedidos.EjecutarSQL(sql);
            return rtdo;
        }

        public double PrecioProducto(string producto)
        {
            DataTable rtdo = new DataTable();
            string sql = "SELECT precio FROM [BD3K6G02_2022].[dbo].[Productos] " +
                            "WHERE codProducto = " + producto;
            rtdo = _BD_Pedidos.EjecutarSQL(sql);
            return Convert.ToDouble(_TE1.BuscarDato(rtdo, "precio"));
        }
        public DataTable RecuperarPedidos() 
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Pedidos]";
            return _BD_Pedidos.EjecutarSQL(sql);
        }

        public DataTable RecuperarPedidos(string numPedido = "", string cuitCliente = "", string numDocVendedor = "", int tipoDocVendedor = -1)
        {
            System.Data.DataTable qsy = new DataTable();
            try
            {
                string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Pedidos]
                               WHERE numeroPedido = '" + numPedido + "' or cuitCliente = '" + cuitCliente + "' or numDniVendedor = '" + numDocVendedor + "' or tipoDniVendedor = '" + tipoDocVendedor + "';";
                qsy = _BD_Pedidos.EjecutarSQL(sql);

                               
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return qsy;
        }

        public void AltaPedidos(Control.ControlCollection controles)
        {
            string sql = _TE1.InsertarDatos(controles, "Pedidos");
            //string sql = @"INSERT INTO Pedidos(numeroPedido,numeroCotizacion,fechaPedido,tipoDniVendedor,numDniVendedor,
            //                condicionPago,cuitCliente,añoCotizacion)
            //                values"+"("+ this.numPedido+ "," + this.numCotizacion + ","+ " "+ "," + this.tipoDocVendedor + ","+ 
            //                this.numDocVendedor + ","+  this.condicionPago + ","+this.cuitCliente + ","+ this.anioCotizacion+")";
            if (sql != "")
            {
                _BD_Pedidos.CargarDatos(sql);
            }
            else
                MessageBox.Show("No se cargó correctamente el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Modificar(DataGridView grilla)
        {
            string SqlModificar = "UPDATE [BD3K6G02_2022].[dbo].[Pedidos] SET ";
            //SqlModificar += " numeroPedido = " + this.numPedido;
            SqlModificar += " tipoDniVendedor = " + this.tipoDocVendedor;
            SqlModificar += ", numDniVendedor = " + this.numDocVendedor;
            SqlModificar += ", fechaPedido = '" + this.dtpFecha.ToShortDateString() + "'";
            SqlModificar += ", condicionPago = '" + this.condicionPago + "'";
            SqlModificar += ", cuitCliente = " + this.cuitCliente;
            SqlModificar += ", añoCotizacion = " + this.añoCotizacion;
            SqlModificar += " WHERE numeroPedido = " + this.numPedido + "; ";

            foreach (DataGridViewRow fila in grilla.Rows)
            {
                SqlModificar += "INSERT [BD3K6G02_2022].[dbo].[DetallePedido] (numeroPedido, codigoProducto, cantidad, precio) VALUES (";
                SqlModificar += this.numPedido;
                SqlModificar += ", " + fila.Cells[0].Value;
                SqlModificar += ", " + fila.Cells[1].Value;
                SqlModificar += ", " + fila.Cells[2].Value.ToString().Replace(",", ".") + "); ";
            }

            if (_BD_Pedidos.Modificar(SqlModificar) == BD_acceso_a_datos.TipoEstado.correcto)
                MessageBox.Show("Se modificó correctamente");
            else
                MessageBox.Show("No se modificó, hubo error");

        }    
        
        public void Borrar(string numPedido)
        {
            string SqlBorrar = "DELETE FROM [BD3K6G02_2022].[dbo].[DetallePedido] WHERE numeroPedido = " + numPedido + "; ";
            SqlBorrar += "DELETE FROM [BD3K6G02_2022].[dbo].[Pedidos] WHERE numeroPedido = " + numPedido + "; ";
            if (_BD_Pedidos.Borrar(SqlBorrar) == BD_acceso_a_datos.TipoEstado.correcto)
                MessageBox.Show("Se borró exitosamente");
            else
                MessageBox.Show("No se borró, hubo error");
        }

        internal void Grabar(DataGridView grilla)
        {
            string sql = "INSERT [BD3K6G02_2022].[dbo].[Pedidos] (numeroPedido, numeroCotizacion, fechaPedido, tipoDniVendedor, numDniVendedor, condicionPago, cuitCliente, añoCotizacion) VALUES (";
            sql += this.numPedido + ", ";
            sql += this.numCotizacion + ", ";
            sql += "CONVERT (date, '" + this.dtpFecha + "', 103)" + ", ";
            sql += this.tipoDocVendedor + ", ";
            sql += this.numDocVendedor + ", ";
            sql += this.condicionPago + ", ";
            sql += this.cuitCliente + ", ";
            sql += this.añoCotizacion;
            sql += "); ";

            foreach (DataGridViewRow fila in grilla.Rows)
            {
                sql += "INSERT [BD3K6G02_2022].[dbo].[DetallePedido] (numeroPedido, codigoProducto, cantidad, precio) VALUES (";
                sql += this.numPedido;
                sql += ", " + fila.Cells[0].Value;
                sql += ", " + fila.Cells[1].Value;
                sql += ", " + fila.Cells[2].Value.ToString().Replace(",", ".") + "); ";
            }

            if (_BD_Pedidos.Insertar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataTable RecuperarPedidoPorNumPedido(string numeroPedido)
        {
            string sql = "SELECT * FROM [BD3K6G02_2022].[dbo].[Pedidos] WHERE numeroPedido  = '" + numeroPedido + "'";
            return _BD_Pedidos.EjecutarSQL(sql);

        }
        public DataTable RecuperarDetallesPed(string numero)
        {
            string sql = "SELECT codigoProducto as Producto, cantidad as Cant, Precio FROM [BD3K6G02_2022].[dbo].[DetallePedido] " +
                            "WHERE numeroPedido = " + numero + ";";
            return _BD_Pedidos.EjecutarSQL(sql);
        }
        public void BorrarDetalles(string numero)
        {
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[DetallePedido] WHERE numeroPedido = " + numero + ";"; //borramos todos los productos de ese pedido
            _BD_Pedidos.EjecutarSQL(sql);
            return;
        }



    }
}
