using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuLuzNet.Clases
{
    public class EstructuraCombo
    {
        public string Display { get; set; }
        public string Value { get; set; }
        public string Sql { get; set; }
        public DataTable Tabla { get; set; }
    }
}
