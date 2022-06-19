using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.ABMs.Empleados;
using TuLuzNet.Clases;
using TuLuzNet.Negocio;

namespace TuLuzNet.ABMs
{
    public partial class Frm_ABM_Empleados : Form
    {
        Ne_Empleados _NE = new Ne_Empleados();
        public Frm_ABM_Empleados()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Empleados_Load(object sender, EventArgs e)
        {
            cmbTipoDocumento.Cargar(_NE.DatosCombo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaEmpleados formAltaEmpleados = new Frm_AltaEmpleados();
            formAltaEmpleados.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.Rows.Count == 1)
            {
                MessageBox.Show("La grilla está vacial", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Frm_ModificarEmpleado formModificarEmpleados = new Frm_ModificarEmpleado();
            if (dataGridViewEmpleados.CurrentRow != null)
            {
                formModificarEmpleados._telefono = dataGridViewEmpleados.CurrentRow.Cells[6].Value.ToString();
                formModificarEmpleados.Show();
            }
            else
                MessageBox.Show("No se seleccionó NADA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewEmpleados.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewEmpleados.DataSource = _NE.RecuperarEmpleados();
                chkBoxTodos.Checked = false;
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty || txtBoxApellido.Text != string.Empty || txtBoxNumDoc.Text != string.Empty || cmbTipoDocumento.SelectedIndex != -1)
                {
                    //string x = ComboBox01.SelectedIndex.ToString();
                    this.dataGridViewEmpleados.DataSource = _NE.RecuperarEmpleados(txtBoxNombre.Text, txtBoxApellido.Text, txtBoxNumDoc.Text, cmbTipoDocumento.SelectedIndex);
                    if (dataGridViewEmpleados.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró ningun campo que cumpla los parámetros.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxApellido.Text = "";
                        txtBoxNombre.Text = "";
                        txtBoxNumDoc.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese parámetros en los campos a buscar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void txtBoxApellido_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Text = "";
            txtBoxNumDoc.Text = "";
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void txtBoxNombre_Click(object sender, EventArgs e)
        {
            txtBoxApellido.Text = "";
            txtBoxNumDoc.Text = "";
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void txtBoxNumDoc_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Text = "";
            txtBoxApellido.Text = "";
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void cmbTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            txtBoxNombre.Text = "";
            txtBoxNumDoc.Text = "";
            txtBoxNumDoc.Text = "";
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            string _numDocEmpleado = dataGridViewEmpleados.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show("¿Está seguro de borrar el usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _NE.Borrar(_numDocEmpleado);
            }
        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }
    }
}
