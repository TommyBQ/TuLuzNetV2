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
    class Ne_Barrios
    {
        BD_acceso_a_datos _BD_barrios = new BD_acceso_a_datos();

        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public int _localidadBarrio { get; set; }
        public int _idBarrio { get; set; }

        public string _nombreBarrio { get; set; }

        public DataTable RecuperarBarrios()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Barrio]";
            return _BD_barrios.EjecutarSQL(sql);
        }
        public DataTable RecuperarBarrios(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Barrio] WHERE nombre = '" + nombre + "'";
            return _BD_barrios.EjecutarSQL(sql);
        }
        public DataTable RecuperarBarrioXid(string idBarrio)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Barrio] WHERE codBarrio = '" + idBarrio + "'";
            return _BD_barrios.EjecutarSQL(sql);
        }
        public void InsertarBarrio(string NombreBarrio,string CodigoLocalidad)
        {
            //  string sql = @"Insert into dbo.Barrio (codBarrio,nombre,codLocalidad) values (9,'Parque la Gruta Oeste1',15)"

            string sql = @"Insert into [BD3K6G02_2022].[dbo].[Barrio] (nombre,codLocalidad) values ("+ "'" + NombreBarrio + "'" + "," + CodigoLocalidad.ToString() + ")";

           // return (sql);

            _BD_barrios.Insertar(sql);
        }

        public void AltaBarrios(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "Barrio");
            if (sql != "")
            {
                _BD_barrios.Insertar(sql);
                MessageBox.Show("Se cargó el Barrio.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se cargó el Barrio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Modificar()
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Barrio] SET nombre = 'BPQ1', codLocalidad = 3 WHERE codBarrio = 13
            string sql = "UPDATE[BD3K6G02_2022].[dbo].[Barrio] SET ";
            sql += "nombre = " + _TE.DatosTexto(this._nombreBarrio);
            sql += ", codLocalidad = " + this._localidadBarrio;
            sql += " WHERE codBarrio = " + this._idBarrio;

            if(_BD_barrios.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error");
            }
        }

        public void Borrar(string idBarrio)
        {
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[Barrio] WHERE codBarrio = " + idBarrio;
            if(_BD_barrios.Borrar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
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
            Ec.Display = "nombre";
            Ec.Value = "codLocalidad";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Localidad]";
            Ec.Tabla = _BD_barrios.EjecutarSQL(Ec.Sql);
            return Ec;
        }
        
    }
}
