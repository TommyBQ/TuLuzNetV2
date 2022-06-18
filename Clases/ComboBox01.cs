using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLuzNet.Clases
{
    public class ComboBox01 : ComboBox
    {
        public string _columna { get; set; }
        public string _MensajeError { get; set; }
        public bool _Validable { get; set; }
        public bool _repetible { get; set; }

        public void Cargar(EstructuraCombo Ec)
        {
            this.DisplayMember = Ec.Display;
            this.ValueMember = Ec.Value;
            this.DataSource = Ec.Tabla;
            this.SelectedIndex = -1;
        }
        public void Cargar(string Display, string Value, DataTable Tabla)
        {
            this.DisplayMember = Display;
            this.ValueMember = Value;
            this.DataSource = Tabla;
        }
    }
}

