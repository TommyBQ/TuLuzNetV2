using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLuzNet.Procedimientos.DetalleFactura
{
    public partial class Frm_DetalleFacturaModificar : Form
    {
        public Frm_DetalleFacturaModificar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
