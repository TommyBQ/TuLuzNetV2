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
using TuLuzNet.Procedimientos.DetalleFactura;
using TuLuzNet.Clases;

namespace TuLuzNet.Procedimientos.Factura
{
    public partial class Frm_AltaFactura : Form
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        Ne_Facturas _NF = new Ne_Facturas();

        Ne_Empleados _NE = new Ne_Empleados();

        Ne_Productos _NP = new Ne_Productos();

        Ne_DetalleFactura detFactura = new Ne_DetalleFactura();
        public Frm_AltaFactura()
        {
            InitializeComponent();
        }

        private void Frm_AltaFactura_Load(object sender, EventArgs e)
        {
            cmbProducto.Cargar(_NP.DatosCombo1());
            cmb_docEmpleados.Cargar(_NE.DatosComboDoc());
            txtNumFactura.Text = _NF.obtenerNumFactura().ToString();
            txtNumDetalleFactura.Text = _NF.obtenerNumDetFactura().ToString();
            this.CargarGrilla();
        }

        private void CargarGrilla()
        {
            dataGridViewDetalleFac.Columns.Add("Producto", "Producto");
            dataGridViewDetalleFac.Columns.Add("Cantidad", "Cantidad");
            dataGridViewDetalleFac.Columns.Add("Precio", "Precio X Cantidad");
            dataGridViewDetalleFac.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarDetalleFac_Click(object sender, EventArgs e)
        {
            Frm_DetalleFacturaAlta frmDetFactura = new Frm_DetalleFacturaAlta();
            frmDetFactura.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePickerFecha.Value.ToShortDateString());
            if (_TE.Validar(this.Controls) == true)
            {
                //_NF.AltaFacturas(this.Controls);
                _NF.numeroDetFactura = int.Parse(this.txtNumDetalleFactura.Text);
                _NF.numeroFactura = int.Parse(this.txtNumFactura.Text);
                _NF.fecha = this.dtpFecha.Value;
                _NF.tipoFactura = this.txtTipoFactura.Text;
                _NF.cuil = txtCuilCuit.Text;
                _NF.numDocEmpleado = int.Parse(this.cmb_docEmpleados.SelectedValue.ToString());
                //_NF.activo = this.chk_Activo.Checked;
                if (this.chk_Activo.Checked)
                {
                    _NF.activo = 1;
                }
                else
                {
                    _NF.activo = 0;
                }
                _NF.Grabar(dataGridViewDetalleFac);
            }
        }

        private void grid011_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            this.dataGridViewDetalleFac.DataSource = null;

            if (txtNumFactura.Text != "")
            {
                this.dataGridViewDetalleFac.DataSource = detFactura.RecuperarTodosDetallesFacturaXFactura(int.Parse(txtNumFactura.Text));
                if (dataGridViewDetalleFac.Rows.Count == 1)
                {
                    MessageBox.Show("No se encontró ninguna factura", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else
            {
                MessageBox.Show("No se ingresó un N° de Factura para buscar los detalles.");
            }
        }

        private void btnAgregarDetalleCot_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text == "" || cmbProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("No se cargó la Cantidad o Producto"); return;
                }
                int cont_fila = dataGridViewDetalleFac.RowCount;
                int num_fila = 0;
                bool existe = false;

                if (cont_fila == 0)
                {
                    double precio = Convert.ToDouble(txtCantidad.Text) * _NF.PrecioProducto(cmbProducto.SelectedValue.ToString());
                    dataGridViewDetalleFac.Rows.Add(cmbProducto.SelectedValue.ToString(), txtCantidad.Text, precio);
                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dataGridViewDetalleFac.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == cmbProducto.SelectedValue.ToString())
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if (existe) //&& (Convert.ToDouble(dataGridViewDetalleCot.Rows[num_fila].Cells[2].Value)/Convert.ToDouble(dataGridViewDetalleCot.Rows[num_fila].Cells[1].Value)) == _NCO.PrecioProducto(cmbProducto.SelectedValue.ToString()))
                    {
                        dataGridViewDetalleFac.Rows[num_fila].Cells[1].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridViewDetalleFac.Rows[num_fila].Cells[1].Value)).ToString();
                        double precio = Convert.ToDouble(dataGridViewDetalleFac.Rows[num_fila].Cells[1].Value) * _NF.PrecioProducto(cmbProducto.SelectedValue.ToString());
                        dataGridViewDetalleFac.Rows[num_fila].Cells[2].Value = precio.ToString();
                    }
                    else
                    {
                        double precio = Convert.ToDouble(txtCantidad.Text) * _NF.PrecioProducto(cmbProducto.SelectedValue.ToString());
                        dataGridViewDetalleFac.Rows.Add(cmbProducto.SelectedValue.ToString(), txtCantidad.Text, precio);
                        cont_fila++;
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow Fila in dataGridViewDetalleFac.Rows)
            {
                double subtotal = Convert.ToDouble(Fila.Cells[2].Value);
                total += subtotal;
            }
            txtTotal.Text = total.ToString();
        }

        private void btnBorrarDetalleCot_Click(object sender, EventArgs e)
        {
            dataGridViewDetalleFac.Rows.Remove(dataGridViewDetalleFac.CurrentRow);
        }

        private void txtNumFactura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
