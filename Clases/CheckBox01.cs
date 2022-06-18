using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLuzNet.Clases
{
    internal class CheckBox01 : CheckBox
    {
        public string _columna { get; set; }
        public bool _validable { get; set; }
        public string _mensajeError { get; set; }
    }
}
