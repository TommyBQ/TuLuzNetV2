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
using TuLuzNet.ABMs.Pedidos;
using System.Data;

namespace TuLuzNet.ABMs.Pedidos
{
    
    public partial class Frm_Modificar_Pedidos : Form

    { 
        public string _numeroPedido { get; set; }
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Pedidos _Np = new Ne_Pedidos();
        Ne_TipoDocumento _Nt = new Ne_TipoDocumento();
        Ne_Clientes _Nc = new Ne_Clientes();
        Ne_Productos _Npo = new Ne_Productos();
        Ne_Cotizaciones _NCO = new Ne_Cotizaciones();
        
        
        public Frm_Modificar_Pedidos()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Pedidos_Load(object sender, EventArgs e)
        {
            //cargar comboboxs
            cmbTDVendedor.Cargar(_Np.DatosCombo());
            cmbCuitCliente.Cargar(_Nc.DatosCombo());
            cmbProducto.Cargar(_Npo.DatosCombo1());
            //cargar datos
            this.RecuperarPedido();
            this.RecuperarDetallePedido();
                
        }

        public void RecuperarDetallePedido()
        {
            this.dataGridViewDetallePed.DataSource = null;
            //this.dataGridViewDetalleCot.DataSource = _NCO.RecuperarDetallesCot(this.txtNumero.Text.ToString(), this.txtAño.Text.ToString());
            DataTable Tabla = _Np.RecuperarDetallesPed(this.txtNumPedido.Text.ToString());
            CargarGrilla(Tabla); ;
        }
        public void CargarGrilla(DataTable tabla)
        {
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
        public void RecuperarPedido()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = _Np.RecuperarPedidoPorNumPedido(_numeroPedido);
            _TE.CargarFormulario(this.Controls, tabla1);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarPedido_Click(object sender, EventArgs e)
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
                _Np.numPedido = int.Parse(this.txtNumPedido.Text);
                _Np.numCotizacion = int.Parse(this.txtNumCotizacion.Text);
                _Np.añoCotizacion = int.Parse(this.txtAñoCotizacion.Text);
                _Np.cuitCliente = this.cmbCuitCliente.Text;
                _Np.dtpFecha = Convert.ToDateTime(this.dtpFecha.Value.ToString());
                _Np.numDocVendedor = int.Parse(this.txtDocVendedor.Text);
                _Np.tipoDocVendedor = (int)this.cmbTDVendedor.SelectedValue;
                _Np.condicionPago = this.txtCondPago.Text;
                _Np.BorrarDetalles(this.txtNumPedido.Text);
                _Np.Modificar(dataGridViewDetallePed);
            }
        }

        private void txtBoxCondPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxTDVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDocVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCondicionPago_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoDocVendedor_Click(object sender, EventArgs e)
        {

        }

        private void lblNumDocVendedor_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarDetalleCot_Click(object sender, EventArgs e)
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
                    double precio = Convert.ToDouble(txtCantidad.Text) * _NCO.PrecioProducto(cmbProducto.SelectedValue.ToString());
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
                        double precio = Convert.ToDouble(dataGridViewDetallePed.Rows[num_fila].Cells[1].Value) * _NCO.PrecioProducto(cmbProducto.SelectedValue.ToString());
                        dataGridViewDetallePed.Rows[num_fila].Cells[2].Value = precio.ToString();
                    }
                    else
                    {
                        double precio = Convert.ToDouble(txtCantidad.Text) * _NCO.PrecioProducto(cmbProducto.SelectedValue.ToString());
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

        private void btnBorrarDetalleCot_Click(object sender, EventArgs e)
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
    }
}
