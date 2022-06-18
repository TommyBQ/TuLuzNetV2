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




namespace TuLuzNet.ABMs.Pedidos
{
    public partial class Frm_ABM_Pedidos : Form
    {
        Ne_Pedidos _NE = new Ne_Pedidos();

        public Frm_ABM_Pedidos()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Pedidos_Load(object sender, EventArgs e)
        {
            cmbTipoDocVendedor.Cargar(_NE.DatosCombo());
        }


        private void grBoxFiltros_Enter(object sender, EventArgs e)
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
            Frm_Alta_Pedidos formAltaPedidos = new Frm_Alta_Pedidos();
            formAltaPedidos.Show();
        }

        private void txtBoxNumPedido_Click(object sender, EventArgs e)
        {
            txtBoxCuitCliente.Text = "";
            txtBoxDocVendedor.Text = "";
            cmbTipoDocVendedor.SelectedIndex = -1;
            
        }

        private void txtBoxCuitCliente_Click(object sender, EventArgs e)
        {
            txtBoxNumPedido.Text = "";
            txtBoxDocVendedor.Text = "";
            cmbTipoDocVendedor.SelectedIndex = -1;
        }

        private void txtBoxDocVendedor_Click(object sender, EventArgs e)
        {
            txtBoxNumPedido.Text = "";
            txtBoxCuitCliente.Text = "";
            cmbTipoDocVendedor.SelectedIndex = -1;
        }

        private void cmbTipoDocVendedor_SelectedValueChanged(object sender, EventArgs e)
        {
            txtBoxNumPedido.Text = "";
            txtBoxCuitCliente.Text = "";
            txtBoxDocVendedor.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPedidos.Rows.Count == 0)
            {
                MessageBox.Show("La grilla esta vacia", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Frm_Modificar_Pedidos formModificarPedidos = new Frm_Modificar_Pedidos();
            if (dataGridViewPedidos.CurrentRow != null)
            {
                formModificarPedidos._numeroPedido = dataGridViewPedidos.CurrentRow.Cells[0].Value.ToString();
                formModificarPedidos.Show();
            }
            else
                MessageBox.Show("No hubo ninguna seleccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ne_Pedidos pedidos = new Ne_Pedidos();
            this.dataGridViewPedidos.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewPedidos.DataSource = pedidos.RecuperarPedidos();
                chkBoxTodos.Checked = false;
            }
            else 
            {
                if (txtBoxNumPedido.Text != string.Empty || txtBoxCuitCliente.Text != string.Empty || txtBoxDocVendedor.Text != string.Empty || cmbTipoDocVendedor.SelectedIndex != -1)
                {
                    //string x = ComboBox01.SelectedIndex.ToString();
                    this.dataGridViewPedidos.DataSource = pedidos.RecuperarPedidos(txtBoxNumPedido.Text, txtBoxCuitCliente.Text, txtBoxDocVendedor.Text, cmbTipoDocVendedor.SelectedIndex);
                    if (dataGridViewPedidos.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun campo que cumpla los parámetros.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxNumPedido.Text = "";
                        txtBoxCuitCliente.Text = "";
                        txtBoxDocVendedor.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese parámetros en los campos a buscar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            cmbTipoDocVendedor.SelectedIndex = -1;
        }

        private void cmbTipoDocVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string numPedido = dataGridViewPedidos.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("¿Está seguro de borrar este pedido?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _NE.Borrar(numPedido);
            }
        }
    }
}
