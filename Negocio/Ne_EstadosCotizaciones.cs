using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuLuzNet.Clases;

namespace TuLuzNet.Negocio
{
    public class Ne_EstadosCotizaciones
    {
        public string descripcion { get; set; }
        public int codEstado { get; set; }

        BD_acceso_a_datos _BD_Estados = new BD_acceso_a_datos();
        public EstructuraCombo DatosCombo()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "descripcion";
            Ec.Value = "codEstado";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[EstadosCotizaciones]";
            Ec.Tabla = _BD_Estados.EjecutarSQL(Ec.Sql);
            return Ec;
        }
    }
}
