using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.ABMs.Barrios;
using TuLuzNet.Negocio;
using TuLuzNet.Clases;


namespace TuLuzNet.ABMs
{
    public partial class Frm_ABM_Barrios : Form
    {

        Ne_Barrios _NB = new Ne_Barrios();
        public Frm_ABM_Barrios()
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
            Frm_AltaBarrios formAltaBarrios = new Frm_AltaBarrios();
            formAltaBarrios.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dataGridViewBarrios.Rows.Count == 1)
            {
                MessageBox.Show("La grilla esta vacia", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridViewBarrios.CurrentRow != null)
            {
                Frm_ModificarBarrio formModificarBarrios = new Frm_ModificarBarrio();
                formModificarBarrios.idBarrio = dataGridViewBarrios.CurrentRow.Cells[0].Value.ToString();
                formModificarBarrios.Show();
            }
            else
            {
                MessageBox.Show("No se selecciono NADA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ne_Barrios barrios = new Ne_Barrios();
            this.dataGridViewBarrios.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewBarrios.DataSource = barrios.RecuperarBarrios();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty)
                {
                    this.dataGridViewBarrios.DataSource = barrios.RecuperarBarrios(txtBoxNombre.Text);
                    if (dataGridViewBarrios.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun Barrio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nombre a buscar o marque la opcion de Todos.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void dataGridViewBarrios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void chkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idBarrio = dataGridViewBarrios.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Está seguro de borrar el usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _NB.Borrar(idBarrio);
            }
        }
    }
}
