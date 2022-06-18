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
    public class Ne_Proveedores
    {
        public string cuit { get; set; }
        public string razon_social { get; set; }
        public string telefono { get; set; }
        public string contacto { get; set; }
        public bool activo { get; set; }

        BD_acceso_a_datos _BD_empleados = new BD_acceso_a_datos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public DataTable RecuperarProveedor()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Proveedor]";
            return _BD_empleados.EjecutarSQL(sql);
        }
        public DataTable RecuperarProveedorXRazonSocial(string razon_social)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Proveedor] WHERE razonSocial LIKE '%" + razon_social + "%'";
            return _BD_empleados.EjecutarSQL(sql);
        }
        public DataTable RecuperarProveedorXCUIT(string cuit)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Proveedor] WHERE cuitProveedor LIKE '%" + cuit + "%'";
            return _BD_empleados.EjecutarSQL(sql);
        }

        public void AltaProveedor(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "Proveedor");
            if (sql != "")
            {
                _BD_empleados.CargarDatos(sql);
            }
            else
                MessageBox.Show("No se cargó el Proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Modificar()
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Proveedor] SET siglas = 'A' , nombre = 'DD' WHERE nombre ='DSAD';
            int activoProveedor = this.activo ? 1 : 0;
            string sql = "UPDATE[BD3K6G02_2022].[dbo].[Proveedor] SET ";
            sql += "cuitProveedor = " + _TE.DatosTexto(this.cuit);
            sql += ", razonSocial = " + _TE.DatosTexto(this.razon_social);
            sql += ", contacto = " + _TE.DatosTexto(this.contacto);
            sql += ", telefono = " + _TE.DatosTexto(this.telefono);
            sql += ", activo = " + activoProveedor;
            sql += " WHERE cuitProveedor = " + _TE.DatosTexto(this.cuit);

            if (_BD_empleados.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error");
            }
        }

        public void Borrar(string cuitProveedor)
        {
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[Proveedor] WHERE cuitProveedor = " + cuitProveedor;
            if (_BD_empleados.Borrar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se borro existosamente");
            }
            else
            {
                MessageBox.Show("No se borro, hubo error");
            }
        }

    }
}
