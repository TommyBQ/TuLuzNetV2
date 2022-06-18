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

namespace TuLuzNet.Procedimientos.Cotizaciones
{
    public partial class Frm_ABMC_Cotizaciones : Form
    {
        Ne_Cotizaciones _NE = new Ne_Cotizaciones();
        public Frm_ABMC_Cotizaciones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal frm_PaginaPrincipal = new Frm_PaginaPrincipal();
            frm_PaginaPrincipal.Show();
        }
        //modificar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCotizaciones.Rows.Count == 1)
            {
                MessageBox.Show("La grilla está vacial", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Frm_ModificarCotizacion frmModificarCotizacion = new Frm_ModificarCotizacion();
            if (dataGridViewCotizaciones.CurrentRow != null)
            {
                frmModificarCotizacion._numero = dataGridViewCotizaciones.CurrentRow.Cells[0].Value.ToString();
                frmModificarCotizacion.Show();
            }
            else
                MessageBox.Show("No se seleccionó NADA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //botones para busqueda
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewCotizaciones.DataSource = null;
            if (txtAño.Text != "" || txtCuitCliente.Text != "" || txtNumero.Text != "" || cmbEstado.SelectedIndex != -1)
            {
                this.dataGridViewCotizaciones.DataSource = _NE.RecuperarCotizaciones(txtNumero.Text, txtAño.Text, txtCuitCliente.Text, cmbEstado.SelectedIndex+1);
                if (dataGridViewCotizaciones.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningun campo que cumpla los parámetros.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumero.Text = "";
                    txtCuitCliente.Text = "";
                    txtAño.Text = "";
                }
            }
            
        }
        private void Frm_ABMC_Cotizaciones_Load(object sender, EventArgs e)
        {
            cmbEstado.Cargar(_NE.DatosCombo());
        }
        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            this.dataGridViewCotizaciones.DataSource = null;
            this.dataGridViewCotizaciones.DataSource = _NE.RecuperarCotizaciones();
        }

        //campos busqueda
        private void txtNumero_Click(object sender, EventArgs e)
        {
            txtAño.Text = "";
            txtCuitCliente.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void txtAño_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtCuitCliente.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void txtCuitCliente_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtAño.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void cmbEstado_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtAño.Text = "";
            txtCuitCliente.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_AltaCotizacion frm_AltaCotizacion= new Frm_AltaCotizacion();
            frm_AltaCotizacion.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea borrar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string _numeroCotizacion = dataGridViewCotizaciones.CurrentRow.Cells[0].Value.ToString();
                string _año = dataGridViewCotizaciones.CurrentRow.Cells[1].Value.ToString();
                _NE.BorrarDetalles(_numeroCotizacion, _año);
                _NE.BorrarCotizacion(_numeroCotizacion, _año);
            }
        }
    }
}
