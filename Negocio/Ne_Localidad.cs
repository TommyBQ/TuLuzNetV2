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
    class Ne_Localidad
    {
        BD_acceso_a_datos _BD_localidades = new BD_acceso_a_datos();

        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public int _codProvincia { get; set; }
        public int _idLocalidad { get; set; }

        public string _nombreLocalidad { get; set; }
        public DataTable RecuperarLocalidades()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Localidad]";
            return _BD_localidades.EjecutarSQL(sql);
        }
        public DataTable RecuperarLocalidades(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Localidad] WHERE nombre = '" + nombre + "'";
            return _BD_localidades.EjecutarSQL(sql);
        }
        public DataTable RecuperarLocalidadXid(string idLocalidad)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Localidad] WHERE codLocalidad = '" + idLocalidad + "'";
            return _BD_localidades.EjecutarSQL(sql);
        }
        public EstructuraCombo DatosCombo()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "nombre";
            Ec.Value = "codProvincia";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Provincia]";
            Ec.Tabla = _BD_localidades.EjecutarSQL(Ec.Sql);
            return Ec;
        }


        public void AltaLocalidad(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "Localidad");
            if (sql != "")
            {
                _BD_localidades.Insertar(sql);
                MessageBox.Show("Se cargó la localidad.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se cargó la localidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Modificar()
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Localidad] SET nombre = 'Cordobaaa', codProvincia = '3' WHERE codLocalidad = '1'
            string sql = "UPDATE[BD3K6G02_2022].[dbo].[Localidad] SET ";
            sql += "nombre = " + _TE.DatosTexto(this._nombreLocalidad);
            sql += ", codProvincia = " + this._codProvincia;
            sql += " WHERE codLocalidad = " + this._idLocalidad;

            if (_BD_localidades.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error");
            }
        }

        public void Borrar(string idLocalidad)
        {
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[Localidad] WHERE codLocalidad = " + idLocalidad;
            if (_BD_localidades.Borrar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
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
