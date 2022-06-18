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
using TuLuzNet.Clases;

namespace TuLuzNet.ABMs.Productos
{
    public partial class Frm_AltaProductos : Form
    {
        Ne_Productos _NP = new Ne_Productos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public Frm_AltaProductos()
        {
            InitializeComponent();
        }

        private void comboBoxBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProveedor_Click(object sender, EventArgs e)
        {

        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidadStock_Click(object sender, EventArgs e)
        {

        }

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[Productos]"))
            {
                _NP.AltaProducto(this.Controls); //aca se mandan todos los txtbox cmbbox
            }
            this.Close();
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblAgregarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void Frm_AltaProductos_Load(object sender, EventArgs e)
        {
            cmbProveedor.Cargar(_NP.DatosCombo());
            cmbProdComponente.Cargar(_NP.DatosCombo1());
            verificarGenerico();
        }

        private void chkGenerico_CheckedChanged(object sender, EventArgs e)
        {
            verificarGenerico();
        }

        private void verificarGenerico()
        {
            if (!chkGenerico.Checked)
            {
                cmbProdComponente.Enabled = false;
            }
            else
            {
                cmbProdComponente.Enabled = true;
            }

        }
    }
}
