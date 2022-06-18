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

namespace TuLuzNet.Procedimientos.Cotizaciones
{
    public partial class Frm_AltaCotizacion : Form
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Cotizaciones _NCO = new Ne_Cotizaciones();
        Ne_Clientes _NCL = new Ne_Clientes();
        Ne_EstadosCotizaciones _NEC = new Ne_EstadosCotizaciones();
        Ne_Empleados _NE = new Ne_Empleados();
        Ne_Productos _NP = new Ne_Productos();
        public Frm_AltaCotizacion()
        {
            InitializeComponent();
        }

        private void Frm_AltaCotizacion_Load(object sender, EventArgs e)
        {
            //carga de combobox
            cmbCuitCliente.Cargar(_NCL.DatosCombo());
            cmbEstado.Cargar(_NEC.DatosCombo());
            cmbTipoDocVendedor.Cargar(_NE.DatosCombo()); //empleado
            cmbProducto.Cargar(_NP.DatosCombo1());
            //mostrar los detalles de la cotizacion
            this.CargarGrilla();
            //definir el numero de cotizacion automaticamente
            txtNumero.Text = _NCO.obtenerNumero().ToString();
        }

        private void CargarGrilla()
        {
            dataGridViewDetalleCot.Columns.Add("Producto", "Producto");
            dataGridViewDetalleCot.Columns.Add("Cantidad", "Cantidad");
            dataGridViewDetalleCot.Columns.Add("Precio", "Precio X Cantidad");
            dataGridViewDetalleCot.Rows.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                foreach (DataGridViewRow Fila in dataGridViewDetalleCot.Rows)
                {
                    double subtotal = Convert.ToDouble(Fila.Cells[2].Value);
                    total += subtotal;
                }
                txtTotal.Text = total.ToString();

                if (_TE.Validar(this.Controls) == true)
                {
                    _NCO.numeroCotizacion = int.Parse(this.txtNumero.Text);
                    _NCO.año = int.Parse(this.txtAño.Text);
                    _NCO.cuitCliente = this.cmbCuitCliente.SelectedValue.ToString();
                    _NCO.tipoDocEmpleado = int.Parse(this.cmbTipoDocVendedor.SelectedValue.ToString());
                    _NCO.numDocEmpleado = int.Parse(this.txtNumDocVendedor.Text);
                    _NCO.codEstado = int.Parse(this.cmbEstado.SelectedValue.ToString());
                    _NCO.nombreCliente = this.txtNomCliente.Text;
                    _NCO.apellidoCliente = this.txtApeCliente.Text;
                    //_NCO.fecha = Convert.ToDateTime(this.txtFecha.Text);
                    _NCO.dtpFecha = this.dtpFecha.Value;
                    _NCO.observaciones = this.txtObservaciones.Text;
                    _NCO.precioTotal = float.Parse(this.txtTotal.Text.ToString());
                    _NCO.motivoPerdida = this.txtMotivoPerdida.Text != null ? this.txtMotivoPerdida.Text : "";
                    _NCO.nombreCompetidor = this.txtNomCompetidor.Text != null ? this.txtNomCompetidor.Text : "";
                    _NCO.Grabar(dataGridViewDetalleCot);
                }
            }
            catch
            { }
        }

        private void cmbCuitCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCuitCliente.SelectedValue.ToString() != "")
            {
                DataTable tabla = new DataTable();
                tabla = _NCO.RecuperarClienteXCuit(cmbCuitCliente.SelectedValue.ToString());
                _NCO.RecargarCliente(this.Controls, tabla);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow Fila in dataGridViewDetalleCot.Rows)
            {
                double subtotal = Convert.ToDouble(Fila.Cells[2].Value);
                total += subtotal;
            }
            txtTotal.Text = total.ToString();
        }

        private void btnAgregarDetalleCot_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text == "" || cmbProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("No se cargó la Cantidad o Producto"); return;
                }
                int cont_fila = dataGridViewDetalleCot.RowCount;
                int num_fila = 0;
                bool existe = false;

                if (cont_fila == 0)
                {
                    double precio = Convert.ToDouble(txtCantidad.Text) * _NCO.PrecioProducto(cmbProducto.SelectedValue.ToString());
                    dataGridViewDetalleCot.Rows.Add(cmbProducto.SelectedValue.ToString(), txtCantidad.Text, precio);
                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dataGridViewDetalleCot.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == cmbProducto.SelectedValue.ToString())
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if (existe) //&& (Convert.ToDouble(dataGridViewDetalleCot.Rows[num_fila].Cells[2].Value)/Convert.ToDouble(dataGridViewDetalleCot.Rows[num_fila].Cells[1].Value)) == _NCO.PrecioProducto(cmbProducto.SelectedValue.ToString()))
                    {
                        dataGridViewDetalleCot.Rows[num_fila].Cells[1].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridViewDetalleCot.Rows[num_fila].Cells[1].Value)).ToString();
                        double precio = Convert.ToDouble(dataGridViewDetalleCot.Rows[num_fila].Cells[1].Value) * _NCO.PrecioProducto(cmbProducto.SelectedValue.ToString());
                        dataGridViewDetalleCot.Rows[num_fila].Cells[2].Value = precio.ToString();
                    }
                    else
                    {
                        double precio = Convert.ToDouble(txtCantidad.Text) * _NCO.PrecioProducto(cmbProducto.SelectedValue.ToString());
                        dataGridViewDetalleCot.Rows.Add(cmbProducto.SelectedValue.ToString(), txtCantidad.Text, precio);
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
            dataGridViewDetalleCot.Rows.Remove(dataGridViewDetalleCot.CurrentRow);
        }

        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cmbEstado.SelectedValue.ToString() != "4")
            {
                this.txtMotivoPerdida.ReadOnly = true;
                this.txtNomCompetidor.ReadOnly = true;
            }
            else
            {
                this.txtMotivoPerdida.ReadOnly = false;
                this.txtNomCompetidor.ReadOnly = false;
            }
        }

        private void txtMotivoPerdida_Click(object sender, EventArgs e)
        {
            this.cmbEstado.SelectedValue = 4;
            this.txtMotivoPerdida.ReadOnly = false;
            this.txtNomCompetidor.ReadOnly = false;
        }

        private void txtNomCompetidor_Click(object sender, EventArgs e)
        {
            this.cmbEstado.SelectedValue = 4;
            this.txtMotivoPerdida.ReadOnly = false;
            this.txtNomCompetidor.ReadOnly = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_ABMC_Cotizaciones frm_ABMC_Cotizaciones = new Frm_ABMC_Cotizaciones();
            frm_ABMC_Cotizaciones.Show();
        }
    }
}
