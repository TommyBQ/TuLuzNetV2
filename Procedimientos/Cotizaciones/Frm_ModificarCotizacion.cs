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
    public partial class Frm_ModificarCotizacion : Form
    {
        public string _numero { get; set; }

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Cotizaciones _NCO = new Ne_Cotizaciones();
        Ne_Clientes _NCL = new Ne_Clientes();
        Ne_EstadosCotizaciones _NEC = new Ne_EstadosCotizaciones();
        Ne_Empleados _NE = new Ne_Empleados();
        Ne_Productos _NP = new Ne_Productos();
        public Frm_ModificarCotizacion()
        {
            InitializeComponent();
        }

        private void Frm_ModificarCotizacion_Load(object sender, EventArgs e)
        {
            //carga de combobox
            cmbCuitCliente.Cargar(_NCL.DatosCombo());
            cmbEstado.Cargar(_NEC.DatosCombo());
            cmbTipoDocVendedor.Cargar(_NE.DatosCombo()); //empleado
            cmbProducto.Cargar(_NP.DatosCombo1());
            this.RecuperarCotizacion();
            //mostrar los detalles de la cotizacion
            this.RecuperarDetalleCot();
            _NCO.CalcularTotal(this.txtNumero.Text, this.txtAño.Text, this.Controls);
        }

        private void RecuperarDetalleCot()
        {
            this.dataGridViewDetalleCot.DataSource = null;
            //this.dataGridViewDetalleCot.DataSource = _NCO.RecuperarDetallesCot(this.txtNumero.Text.ToString(), this.txtAño.Text.ToString());
            DataTable Tabla = _NCO.RecuperarDetallesCot(this.txtNumero.Text.ToString(), this.txtAño.Text.ToString());
            CargarGrilla(Tabla);
        }
        public void CargarGrilla(DataTable tabla)
        {
            dataGridViewDetalleCot.Columns.Add("Producto", "Producto");
            dataGridViewDetalleCot.Columns.Add("Cantidad", "Cantidad");
            dataGridViewDetalleCot.Columns.Add("Precio", "Precio X Cantidad");
            dataGridViewDetalleCot.Rows.Clear();
            for (int filas = 0; filas < tabla.Rows.Count; filas++)
            {
                dataGridViewDetalleCot.Rows.Add();
                for (int columnas = 0; columnas < tabla.Columns.Count; columnas++)
                {
                    dataGridViewDetalleCot.Rows[filas].Cells[columnas].Value = tabla.Rows[filas][columnas];
                }
            }
        }
        private void RecuperarCotizacion()
        {
            DataTable Tabla = new DataTable();
            Tabla = _NCO.RecuperarCotizacionXNum(_numero);
            _TE.CargarFormulario(this.Controls, Tabla);
        }
        private void cmbCuitCliente_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (cmbCuitCliente.SelectedValue.ToString() != "")
            {
                DataTable tabla = new DataTable();
                tabla = _NCO.RecuperarClienteXCuit(cmbCuitCliente.SelectedValue.ToString());
                _NCO.RecargarCliente(this.Controls, tabla);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //_NCO.CalcularTotal(this.txtNumero.Text, this.txtAño.Text);
            //MessageBox.Show(datePicker.Value);
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
                    _NCO.BorrarDetalles(this.txtNumero.Text, this.txtAño.Text);
                    _NCO.Modificar(dataGridViewDetalleCot);
                }
            }
            catch
            {
            }
            //this.Close();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    double precio = Convert.ToDouble(txtCantidad.Text) *_NCO.PrecioProducto(cmbProducto.SelectedValue.ToString());
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

        private void btnBorrarDetalleCot_Click(object sender, EventArgs e)
        {
            dataGridViewDetalleCot.Rows.Remove(dataGridViewDetalleCot.CurrentRow);
        }
/*string _numDocEmpleado = dataGridViewEmpleados.CurrentRow.Cells[1].Value.ToString();
    if (MessageBox.Show("¿Está seguro de borrar el usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
        _NE.Borrar(_numDocEmpleado);
    }*/
        /*
private void btnAgregar_Click(object sender, EventArgs e)
{
   TratamientosEspeciales _TE = new TratamientosEspeciales();
   if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[Barrio]"))
   {
       barrios.AltaBarrios(this.Controls); //aca se mandan todos los txtbox cmbbox
   }
   this.Close();
}
*/
    }
}
