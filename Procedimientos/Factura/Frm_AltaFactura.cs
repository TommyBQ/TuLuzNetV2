using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.Negocio;
using TuLuzNet.Procedimientos.DetalleFactura;

namespace TuLuzNet.Procedimientos.Factura
{
    public partial class Frm_AltaFactura : Form
    {
        Ne_DetalleFactura detFactura = new Ne_DetalleFactura();
        public Frm_AltaFactura()
        {
            InitializeComponent();
        }

        private void Frm_AltaFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarDetalleFac_Click(object sender, EventArgs e)
        {
            Frm_DetalleFacturaAlta frmDetFactura = new Frm_DetalleFacturaAlta();
            frmDetFactura.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePickerFecha.Value.ToShortDateString());
        }

        private void grid011_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            this.dataGridViewDetalleFac.DataSource = null;

            if (txtNumFactura.Text != "")
            {
                this.dataGridViewDetalleFac.DataSource = detFactura.RecuperarTodosDetallesFacturaXFactura(int.Parse(txtNumFactura.Text));
                if (dataGridViewDetalleFac.Rows.Count == 1)
                {
                    MessageBox.Show("No se encontró ninguna factura", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else
            {
                MessageBox.Show("No se ingresó un N° de Factura para buscar los detalles.");
            }
        }
    }
}
