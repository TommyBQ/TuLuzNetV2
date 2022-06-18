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
    class Ne_TipoDocumento
    {
        BD_acceso_a_datos _BD_tipoDocumento = new BD_acceso_a_datos();

        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public string nombre { get; set; }

        public string siglas { get; set; }

        public string nombreAnterior { get; set; }

        public DataTable RecuperarTipoDocumento()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[TipoDocumento]";
            return _BD_tipoDocumento.EjecutarSQL(sql);
        }
        public DataTable RecuperarTipoDocumento(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[TipoDocumento] WHERE nombre LIKE '%" + nombre + "%'";
            return _BD_tipoDocumento.EjecutarSQL(sql);
        }

        public DataTable RecuperarTipoDocumentoXid(string idTipoDocumento)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[TipoDocumento] WHERE idTipoDoc LIKE '%" + idTipoDocumento + "%'";
            return _BD_tipoDocumento.EjecutarSQL(sql);
        }

        public void AltaTipoDocumento(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "TipoDocumento");
            if (sql != "")
            {
                _BD_tipoDocumento.CargarDatos(sql);
            }
            else
                MessageBox.Show("No se cargó el Tipo de Documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void Modificar()
        {
            //UPDATE[BD3K6G02_2022].[dbo].[TipoDocumento] SET siglas = 'A' , nombre = 'DD' WHERE nombre ='DSAD';
            string sql = "UPDATE[BD3K6G02_2022].[dbo].[TipoDocumento] SET ";
            sql += "siglas = " + _TE.DatosTexto(this.siglas);
            sql += ", nombre = " + _TE.DatosTexto(this.nombre);
            sql += " WHERE nombre = " + _TE.DatosTexto(this.nombreAnterior);

            if (_BD_tipoDocumento.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error");
            }
        }

        public void Borrar(string idTipoDocumento)
        {
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[TipoDocumento] WHERE idTipoDoc = " + idTipoDocumento;
            if (_BD_tipoDocumento.Borrar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
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
