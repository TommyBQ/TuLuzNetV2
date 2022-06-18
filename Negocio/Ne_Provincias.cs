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
    class Ne_Provincias
    {
        BD_acceso_a_datos _BD_provincias = new BD_acceso_a_datos();

        TratamientosEspeciales _TE = new TratamientosEspeciales();

        //public int codProvincia { get; set; }
        public string nombre { get; set; }

        public string nombreAnterior { get; set; }

        public string nombreNuevo { get; set; }

        public DataTable RecuperarProvincias()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Provincia]";
            return _BD_provincias.EjecutarSQL(sql);
        }
        public DataTable RecuperarProvincias(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Provincia] WHERE nombre LIKE '%" + nombre + "%'";
            return _BD_provincias.EjecutarSQL(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Provincia (nombre) " + " VALUES (" + "'" + nombre + "'" + ")";
            _BD_provincias.CargarDatos(sqlInsertar);

        }

        public DataTable RecuperaProvinciaXid(string idProvincia)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Provincia] WHERE codProvincia = '" + idProvincia + "'";
            return _BD_provincias.EjecutarSQL(sql);
        }

        public void Modificar()
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Barrio] SET nombre = 'BPQ1', codLocalidad = 3 WHERE codBarrio = 13
            string sql = "UPDATE[BD3K6G02_2022].[dbo].[Provincia] SET ";
            sql += "nombre = " + _TE.DatosTexto(this.nombreNuevo);
            sql += " WHERE nombre = " + _TE.DatosTexto(this.nombreAnterior);

            if (_BD_provincias.Modificar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
            {
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                MessageBox.Show("No se modifico, hubo error");
            }
        }

        public void Borrar(string idProvincia)
        {
            string sql = "DELETE FROM [BD3K6G02_2022].[dbo].[Provincia] WHERE codProvincia = " + idProvincia;
            if (_BD_provincias.Borrar(sql) == BD_acceso_a_datos.TipoEstado.correcto)
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
