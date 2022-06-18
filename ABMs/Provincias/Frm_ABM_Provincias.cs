using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.ABMs.Provincias;
using TuLuzNet.Negocio;

namespace TuLuzNet.ABMs
{
    public partial class Frm_ABM_Provincias : Form
    {
        Ne_Provincias _NP = new Ne_Provincias();
        public Frm_ABM_Provincias()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaProvincias formAltaProvincias = new Frm_AltaProvincias();
            formAltaProvincias.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Frm_ModificarProvincia formModificarProvincias = new Frm_ModificarProvincia();
            //formModificarProvincias.Show();
            if (dataGridViewProvincias.Rows.Count == 1)
            {
                MessageBox.Show("La grilla esta vacia", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridViewProvincias.CurrentRow != null)
            {
                //Frm_ModificarProvincia formModificarProvincias = new Frm_ModificarProvincia();
                Frm_ModificarProvincia formModificarProvincias = new Frm_ModificarProvincia();
                formModificarProvincias.codProvincia = dataGridViewProvincias.CurrentRow.Cells[0].Value.ToString();
                formModificarProvincias.Show();
            }
            else
            {
                MessageBox.Show("No se selecciono NADA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProvincia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ne_Provincias provincias = new Ne_Provincias();
            this.dataGridViewProvincias.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewProvincias.DataSource = provincias.RecuperarProvincias();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty)
                {
                    this.dataGridViewProvincias.DataSource = provincias.RecuperarProvincias(txtBoxNombre.Text);
                    if (dataGridViewProvincias.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ninguna provincia.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nombre a buscar o marque la opcion de Todos.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idProvincia = dataGridViewProvincias.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Está seguro de borrar el usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _NP.Borrar(idProvincia);
            }
        }
    }
}
