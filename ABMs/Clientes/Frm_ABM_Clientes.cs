using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.ABMs.Clientes;
using TuLuzNet.Negocio;
using TuLuzNet.Clases;

namespace TuLuzNet.ABMs
{
    public partial class Frm_ABM_Clientes : Form
    {
        Ne_Clientes _NC = new Ne_Clientes();
        public Frm_ABM_Clientes()
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
            Frm_AltaClientes formAltaClientes = new Frm_AltaClientes();
            formAltaClientes.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Frm_ModificarCliente formModificarClientes = new Frm_ModificarCliente();
            if (dataGridViewClientes.Rows.Count == 1)
            {
                MessageBox.Show("La grilla esta vacia", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridViewClientes.CurrentRow != null)
            {
                Frm_ModificarCliente frmModificarCliente = new Frm_ModificarCliente();
                frmModificarCliente.cuitCliente = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
                frmModificarCliente.Show();
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
            Ne_Clientes clientes = new Ne_Clientes();
            this.dataGridViewClientes.DataSource = null;
            if (chkBoxActivo.Checked)
            {
                this.dataGridViewClientes.DataSource = clientes.RecuperarTodosClientesXActivo(1);
            }
            else if (chkBoxTodos.Checked)
            {
                this.dataGridViewClientes.DataSource = clientes.RecuperarTodosClientes();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty)
                {
                    this.dataGridViewClientes.DataSource = clientes.RecuperarClienteXNombre(txtBoxNombre.Text);
                    if (dataGridViewClientes.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun cliente.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                if (txtBoxApellido.Text != string.Empty)
                {
                    this.dataGridViewClientes.DataSource = clientes.RecuperarClienteXApellido(txtBoxApellido.Text);
                    if (dataGridViewClientes.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun cliente.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                if (txtBoxCUIT.Text != string.Empty)
                {
                    this.dataGridViewClientes.DataSource = clientes.RecuperaPedidoXCliente(txtBoxCUIT.Text);
                    if (dataGridViewClientes.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun cliente.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nombre a buscar o marque la opcion de Todos.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cuitCliente = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Está seguro de borrar el usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _NC.Borrar(cuitCliente);
            }
        }

        private void Frm_ABM_Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
