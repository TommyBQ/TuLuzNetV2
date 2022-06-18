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
using TuLuzNet.ABMs.Pedidos;
using TuLuzNet.Negocio;

namespace TuLuzNet.ABMs.Pedidos
{
    public partial class Frm_Alta_Pedidos : Form
    {
        Ne_Pedidos _NPE = new Ne_Pedidos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Clientes _NCL = new Ne_Clientes();
        Ne_Productos _NPO = new Ne_Productos();
        Ne_Cotizaciones _NCO = new Ne_Cotizaciones();
        public Frm_Alta_Pedidos()
        {
            InitializeComponent();
        }


        private void Frm_Alta_Pedidos_Load(object sender, EventArgs e)
        {
            cmbTDVendedor.Cargar(_NPE.DatosCombo());
            cmbProducto.Cargar(_NPO.DatosCombo1()); ;
            cmbCuitCliente.Cargar(_NCL.DatosCombo());

            txtNumPedido.Text = _NPE.obtenerNumero().ToString();
        }

        private void CargarGrilla(DataTable tabla)
        {
            dataGridViewDetallePed.Columns.Clear();
            dataGridViewDetallePed.Columns.Add("Producto", "Producto");
            dataGridViewDetallePed.Columns.Add("Cantidad", "Cantidad");
            dataGridViewDetallePed.Columns.Add("Precio", "Precio X Cantidad");
            dataGridViewDetallePed.Rows.Clear();
            for (int filas = 0; filas < tabla.Rows.Count; filas++)
            {
                dataGridViewDetallePed.Rows.Add();
                for (int columnas = 0; columnas < tabla.Columns.Count; columnas++)
                {
                    dataGridViewDetallePed.Rows[filas].Cells[columnas].Value = tabla.Rows[filas][columnas];
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[Pedidos]"))
            {
               _NPE.AltaPedidos(this.Controls); 
            }
        }

        private void btnAgregarDetallePed_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text == "" || cmbProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("No se cargó la Cantidad o Producto"); return;
                }
                int cont_fila = dataGridViewDetallePed.RowCount;
                int num_fila = 0;
                bool existe = false;

                if (cont_fila == 0)
                {
                    double precio = Convert.ToDouble(txtCantidad.Text) * _NPE.PrecioProducto(cmbProducto.SelectedValue.ToString());
                    dataGridViewDetallePed.Rows.Add(cmbProducto.SelectedValue.ToString(), txtCantidad.Text, precio);
                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dataGridViewDetallePed.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == cmbProducto.SelectedValue.ToString())
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if (existe) //&& (Convert.ToDouble(dataGridViewDetalleCot.Rows[num_fila].Cells[2].Value)/Convert.ToDouble(dataGridViewDetalleCot.Rows[num_fila].Cells[1].Value)) == _NCO.PrecioProducto(cmbProducto.SelectedValue.ToString()))
                    {
                        dataGridViewDetallePed.Rows[num_fila].Cells[1].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridViewDetallePed.Rows[num_fila].Cells[1].Value)).ToString();
                        double precio = Convert.ToDouble(dataGridViewDetallePed.Rows[num_fila].Cells[1].Value) * _NPE.PrecioProducto(cmbProducto.SelectedValue.ToString());
                        dataGridViewDetallePed.Rows[num_fila].Cells[2].Value = precio.ToString();
                    }
                    else
                    {
                        double precio = Convert.ToDouble(txtCantidad.Text) * _NPE.PrecioProducto(cmbProducto.SelectedValue.ToString());
                        dataGridViewDetallePed.Rows.Add(cmbProducto.SelectedValue.ToString(), txtCantidad.Text, precio);
                        cont_fila++;
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er);
            }
        }

        private void btnBorrarDetallePed_Click(object sender, EventArgs e)
        {
            dataGridViewDetallePed.Rows.Remove(dataGridViewDetallePed.CurrentRow);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow Fila in dataGridViewDetallePed.Rows)
            {
                double subtotal = Convert.ToDouble(Fila.Cells[2].Value);
                total += subtotal;
            }
            txtTotal.Text = total.ToString();
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                foreach (DataGridViewRow Fila in dataGridViewDetallePed.Rows)
                {
                    double subtotal = Convert.ToDouble(Fila.Cells[2].Value);
                    total += subtotal;
                }
                txtTotal.Text = total.ToString();

                if (_TE.Validar(this.Controls) == true)
                {
                    _NPE.numPedido = int.Parse(this.txtNumPedido.Text);
                    _NPE.numCotizacion = int.Parse(this.txtNumCotizacion.Text);
                    _NPE.dtpFecha = this.dtpFecha.Value;
                    _NPE.añoCotizacion = int.Parse(this.txtAñoCotizacion.Text);
                    _NPE.tipoDocVendedor = int.Parse(this.cmbTDVendedor.SelectedValue.ToString());
                    _NPE.numDocVendedor = int.Parse(this.txtDocVendedor.Text);
                    _NPE.condicionPago = _TE.DatosTexto(this.txtCondPago.Text);
                    _NPE.cuitCliente = this.cmbCuitCliente.Text;
                    _NPE.Grabar(dataGridViewDetallePed);
                }
            }
            catch
            { }
        }

        private void btnCargarCotizacion_Click(object sender, EventArgs e)
        {
            RecuperarDetalleCot();
            if (dataGridViewDetallePed.RowCount == 0)
                MessageBox.Show("No existe el numero de Detalle de Cotizacion de ese año", "Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void RecuperarDetalleCot()
        {
            this.dataGridViewDetallePed.DataSource = null;
            //this.dataGridViewDetalleCot.DataSource = _NCO.RecuperarDetallesCot(this.txtNumero.Text.ToString(), this.txtAño.Text.ToString());
            DataTable Tabla = _NCO.RecuperarDetallesCot(this.txtNumCotizacion.Text.ToString(), this.txtAñoCotizacion.Text.ToString());
            CargarGrilla(Tabla);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Frm_ABM_Pedidos frm_ABM_Pedidos = new Frm_ABM_Pedidos();
            frm_ABM_Pedidos.Show();
        }
    }
}
