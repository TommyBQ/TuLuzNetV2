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
    class Ne_DetalleFactura
    {
        BD_acceso_a_datos _BD = new BD_acceso_a_datos();

        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public int numeroDetalleFactura { get; set; }
        public int numeroFactura { get; set; }
        public int cantidad { get; set; }
        public float precioUnitario { get; set; }
        public int codigoProducto { get; set; }

        public DataTable RecuperarTodosDetallesFacturaXFactura(int numFac)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[DetalleFactura] WHERE numFactura = " + numFac;
            return _BD.EjecutarSQL(sql);
        }
        public void AltaDetalleFactura(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "DetalleFactura");
            if (sql != "")
            {
                _BD.Insertar(sql);
                MessageBox.Show("Se cargó el DetalleFactura.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se cargó el DetalleFactura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Modificar()
        {
            string sql = "UPDATE[BD3K6G02_2022].[dbo].[DetalleFactura] SET ";
            sql += "cuitDetalleFactura = " + this.numeroFactura;
            sql += ", nombre = " + this.cantidad;
            sql += ", apellido = " + this.precioUnitario;
            sql += ", activo = " + this.codigoProducto;
            sql += " WHERE numeroDetalleFactura = " + this.numeroDetalleFactura;

            if (_BD.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
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
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[DetalleFactura] WHERE numeroDetalleFactura = " + numeroDetalleFactura;
            if (_BD.Borrar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
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
            Ec.Display = "numeroDetalleFactura";
            Ec.Value = "numeroDetalleFactura";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[DetalleFactura]";
            Ec.Tabla = _BD.EjecutarSQL(Ec.Sql);
            return Ec;
        }
    }
}
