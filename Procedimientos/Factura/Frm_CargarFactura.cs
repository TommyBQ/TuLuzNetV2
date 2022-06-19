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

namespace TuLuzNet.Procedimientos.Factura
{
    public partial class Frm_CargarFactura : Form
    {
        Ne_Facturas facturas = new Ne_Facturas();
        public Frm_CargarFactura()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewFactura.DataSource = null;

            if (txtNumFactura.Text != string.Empty)
            {
                this.dataGridViewFactura.DataSource = facturas.RecuperarFacturasXNumFactura(int.Parse(txtNumFactura.Text));
                if (dataGridViewFactura.Rows.Count == 1)
                {
                    MessageBox.Show("No se encontró ninguna factura", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (chkActivo.Checked)
            {
                this.dataGridViewFactura.DataSource = facturas.RecuperarFacturasXActivo(chkActivo.Checked);
            }
            else if (chkNoActivo.Checked)
            {
                this.dataGridViewFactura.DataSource = facturas.RecuperarFacturasXActivo(chkNoActivo.Checked);

            }
            else
            {
                MessageBox.Show("Ingrese parámetro de búsqueda.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            this.dataGridViewFactura.DataSource = facturas.RecuperarFacturas();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaFactura formAltaFactura = new Frm_AltaFactura();
            formAltaFactura.Show();
        }

        private void Frm_CargarFactura_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
