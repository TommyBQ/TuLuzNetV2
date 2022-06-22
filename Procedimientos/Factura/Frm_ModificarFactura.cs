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

namespace TuLuzNet.Procedimientos.Factura
{
    public partial class Frm_ModificarFactura : Form
    {
        public string _numero { get; set; }

        TratamientosEspeciales _TE = new TratamientosEspeciales();

        Ne_Facturas _NF = new Ne_Facturas();

        Ne_Empleados _NE = new Ne_Empleados();

        Ne_Productos _NP = new Ne_Productos();

        Ne_DetalleFactura detFactura = new Ne_DetalleFactura();
        public Frm_ModificarFactura()
        {
            InitializeComponent();
        }

        private void Frm_ModificarFactura_Load(object sender, EventArgs e)
        {
            cmbProducto.Cargar(_NP.DatosCombo1());
            cmb_docEmpleados.Cargar(_NE.DatosComboDoc());
            this.RecuperarFactura();
            this.RecuperarDetFactura();
        }
        public void CargarGrilla(DataTable tabla)
        {
            dataGridViewDetalleFac.Columns.Add("Producto", "Producto");
            dataGridViewDetalleFac.Columns.Add("Cantidad", "Cantidad");
            dataGridViewDetalleFac.Columns.Add("Precio", "Precio X Cantidad");
            dataGridViewDetalleFac.Rows.Clear();
            for (int filas = 0; filas < tabla.Rows.Count; filas++)
            {
                dataGridViewDetalleFac.Rows.Add();
                for (int columnas = 0; columnas < tabla.Columns.Count; columnas++)
                {
                    dataGridViewDetalleFac.Rows[filas].Cells[columnas].Value = tabla.Rows[filas][columnas];
                }
            }
        }
        private void RecuperarFactura()
        {
            DataTable Tabla = new DataTable();
            Tabla = _NF.RecuperarFacturasXNumFactura(int.Parse(_numero));
            _TE.CargarFormulario(this.Controls, Tabla);
            this.txtNumDetalleFactura.Text = _NF.RecuperarFacturasXNumFactura1(int.Parse(_numero)).ToString();

        }
        private void RecuperarDetFactura()
        {
            DataTable Tabla = new DataTable();
            Tabla = _NF.RecuperarDetallesFac1(int.Parse(_numero));
            //_TE.CargarFormulario(this.Controls, Tabla);
            CargarGrilla(Tabla);
            //dataGridViewDetalleFac.DataSource = Tabla;
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

        private void btnBorrarDetalleCot_Click(object sender, EventArgs e)
        {
            dataGridViewDetalleFac.Rows.Remove(dataGridViewDetalleFac.CurrentRow);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumDetalleFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow Fila in dataGridViewDetalleFac.Rows)
            {
                double subtotal = Convert.ToDouble(Fila.Cells[2].Value);
                total += subtotal;
            }
            this.txtTotal.Text = total.ToString();

            if (_TE.Validar(this.Controls) == true)
            {
                _NF.numeroFactura = int.Parse(this.txtNumFactura.Text);
                _NF.numeroDetFactura = int.Parse(this.txtNumDetalleFactura.Text);
                //_NF.añoCotizacion = int.Parse(this.txtAñoCotizacion.Text);
                _NF.cuil = this.txtCuilCuit.Text;
                _NF.fecha = this.dtpFecha.Value;
                _NF.tipoFactura = this.txtTipoFactura.Text;
                _NF.numDocEmpleado = int.Parse(this.cmb_docEmpleados.SelectedValue.ToString());
                if (this.chk_Activo.Checked)
                {
                    _NF.activo = 1;
                }
                else
                {
                    _NF.activo = 0;
                }
                _NF.Modificar(dataGridViewDetalleFac);

            }
        }
    }
}
