using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.Clases;
using TuLuzNet.Negocio;
using TuLuzNet.ABMs.TipoDocumento;

namespace TuLuzNet.ABMs
{
    public partial class Frm_ABM_TipoDocumentos : Form
    {
        BD_acceso_a_datos _BD = new BD_acceso_a_datos();

        Ne_TipoDocumento _NTD = new Ne_TipoDocumento();

        public Frm_ABM_TipoDocumentos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void Frm_ABM_TipoDocumentos_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewTipoDocumento.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewTipoDocumento.DataSource = _NTD.RecuperarTipoDocumento();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty)
                {
                    this.dataGridViewTipoDocumento.DataSource = _NTD.RecuperarTipoDocumento(txtBoxNombre.Text);
                    if (dataGridViewTipoDocumento.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun Tipo de Documento.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nombre a buscar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Frm_AltaTipoDocumento formAltaTipoDocumento = new Frm_AltaTipoDocumento();

            formAltaTipoDocumento.Show();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTipoDocumento.Rows.Count == 1)
            {
                MessageBox.Show("La grilla esta vacia", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridViewTipoDocumento.CurrentRow != null)
            {
                Frm_ModificarTipoDocumento formModificarTipoDocumento = new Frm_ModificarTipoDocumento();
                formModificarTipoDocumento.idTipoDocumento = dataGridViewTipoDocumento.CurrentRow.Cells[0].Value.ToString();
                formModificarTipoDocumento.Show();
            }
            else
            {
                MessageBox.Show("No se selecciono NADA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewTipoDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idTipoDoc = dataGridViewTipoDocumento.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Está seguro de borrar el usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _NTD.Borrar(idTipoDoc);
            }
        }
    }
}
