using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.ABMs.Proveedores;
using TuLuzNet.Negocio;

namespace TuLuzNet.ABMs
{
    public partial class Frm_ABM_Proveedores : Form
    {
        Ne_Proveedores _NE = new Ne_Proveedores();
        public Frm_ABM_Proveedores()
        {
            InitializeComponent();
        }

        private void chkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_ABM_Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaProveedores formAltaProveedores = new Frm_AltaProveedores();
            formAltaProveedores.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.Rows.Count == 1)
            {
                MessageBox.Show("La grilla está vacial", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Frm_ModificarProveedor formModificarEmpleados = new Frm_ModificarProveedor();
            if (dataGridViewProveedores.CurrentRow != null)
            {
                formModificarEmpleados._cuit = dataGridViewProveedores.CurrentRow.Cells[0].Value.ToString();
                formModificarEmpleados.Show();
            }
            else
                MessageBox.Show("No se seleccionó NADA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewProveedores.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewProveedores.DataSource = _NE.RecuperarProveedor();
                chkBoxTodos.Checked = false;
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxRazonSocial.Text != string.Empty)
                {
                    //string x = ComboBox01.SelectedIndex.ToString();
                    this.dataGridViewProveedores.DataSource = _NE.RecuperarProveedorXRazonSocial(txtBoxRazonSocial.Text);
                    if (dataGridViewProveedores.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun campo que cumpla los parámetros.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxRazonSocial.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese parámetros en los campos a buscar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _cuit = dataGridViewProveedores.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("¿Está seguro de borrar el usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _NE.Borrar(_cuit);
            }
        }
    }
}
