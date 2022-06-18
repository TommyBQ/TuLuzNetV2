using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.ABMs.Productos;
using TuLuzNet.Negocio;
using TuLuzNet.Clases;

namespace TuLuzNet.ABMs
{
    public partial class Frm_ABM_Productos : Form
    {

        Ne_Productos _NP = new Ne_Productos();
        public Frm_ABM_Productos()
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
            Frm_AltaProductos formAltaProductos = new Frm_AltaProductos();
            formAltaProductos.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.Rows.Count == 1)
            {
                MessageBox.Show("La grilla está vacial", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Frm_ModificarProductos formModificarProducto = new Frm_ModificarProductos();
            if (dataGridViewProductos.CurrentRow != null)
            {
                formModificarProducto._codProducto = int.Parse(dataGridViewProductos.CurrentRow.Cells[0].Value.ToString());
                formModificarProducto.Show();
            }
            else
                MessageBox.Show("No se seleccionó NADA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewProductos.DataSource = null;
            if (chkBoxTodos.Checked)
            {
                this.dataGridViewProductos.DataSource = _NP.RecuperarProductos();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtNombre.Text != string.Empty)
                {
                    this.dataGridViewProductos.DataSource = _NP.RecuperarProductoXNombre(txtNombre.Text);
                    if (dataGridViewProductos.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun Producto.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                if (txtBoxNumPedido.Text != string.Empty)
                {
                    this.dataGridViewProductos.DataSource = _NP.RecuperarProductoXcodProducto(int.Parse(txtBoxNumPedido.Text));
                    if (dataGridViewProductos.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun Producto.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                if (txtBoxNumPedido.Text != string.Empty || txtNombre.Text != string.Empty)
                {
                    this.dataGridViewProductos.DataSource = _NP.RecuperarProductos(txtNombre.Text, txtBoxNumPedido.Text);
                    if (dataGridViewProductos.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun campo que cumpla los parámetros.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Text = "";
                        txtBoxNumPedido.Text = "";
                        
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
            string codProducto = dataGridViewProductos.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Está seguro de borrar el usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _NP.Borrar(codProducto);
            }
        }
    }
}
