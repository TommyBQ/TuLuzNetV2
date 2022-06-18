using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.ABMs.Localidades;
using TuLuzNet.Negocio;

namespace TuLuzNet.ABMs
{
    public partial class Frm_ABM_Localidades : Form
    {
        Ne_Localidad _NL = new Ne_Localidad();
        public Frm_ABM_Localidades()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void chkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblLocalidad_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ne_Localidad localidades = new Ne_Localidad();
            this.dataGridViewLocalidades.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewLocalidades.DataSource = localidades.RecuperarLocalidades();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty)
                {
                    this.dataGridViewLocalidades.DataSource = localidades.RecuperarLocalidades(txtBoxNombre.Text);
                    if (dataGridViewLocalidades.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ninguna Localidad", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nombre a buscar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaLocalidades formAltaLocalidades = new Frm_AltaLocalidades();
            formAltaLocalidades.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idLocalidad = dataGridViewLocalidades.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Está seguro de borrar el usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _NL.Borrar(idLocalidad);
            }
        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocalidades.Rows.Count == 1)
            {
                MessageBox.Show("La grilla esta vacia", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridViewLocalidades.CurrentRow != null)
            {
                Frm_ModificarLocalidad formModificarLocalidad = new Frm_ModificarLocalidad();
                formModificarLocalidad.idLocalidad = dataGridViewLocalidades.CurrentRow.Cells[0].Value.ToString();
                formModificarLocalidad.Show();
            }
            else
            {
                MessageBox.Show("No se selecciono NADA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
