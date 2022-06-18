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

namespace TuLuzNet.ABMs.Productos
{
    public partial class Frm_ModificarProductos : Form
    {
        public int _codProducto { get; set; }

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Productos _NP = new Ne_Productos();
        public Frm_ModificarProductos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkGenerico_CheckedChanged(object sender, EventArgs e)
        {
            verificarGenerico();
        }

        private void verificarGenerico()
        {
            if (!chkGenerico.Checked)
            {
                cmbProdComponente.Enabled = false;
            }
            else
            {
                cmbProdComponente.Enabled = true;
            }

        }

        private void Frm_ModificarProductos_Load(object sender, EventArgs e)
        {
            cmbProveedor.Cargar(_NP.DatosCombo());
            cmbProdComponente.Cargar(_NP.DatosCombo1());
            this.RecuperarProducto();
        }

        private void RecuperarProducto()
        {
            DataTable tabla = new DataTable();
            tabla = _NP.RecuperarProductoXcodProducto(_codProducto);
            _TE.CargarFormulario(this.Controls, tabla);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Productos] SET nombre = 'abcd', precio = 3, cantStock = 99 ,
            //descripcion = 'ej', cuitProveedor = 30110014898 ,codProductoEquivalente = 1  WHERE codProducto = 15;
            if (_TE.Validar(this.Controls) == true)
            {
                _NP.codProducto = _codProducto;
                _NP.nombre = this.txtNombre.Text;
                _NP.precio = int.Parse(this.txtPrecio.Text);
                _NP.cantStock = int.Parse(this.txtStock.Text);
                _NP.descripcion = this.txtDescripcion.Text;
                _NP.cuitProveedor = Convert.ToInt64(this.cmbProveedor.SelectedValue);
                _NP.codProductoEquivalente = Convert.ToInt32(this.cmbProdComponente.SelectedValue);
                _NP.Modificar();
            }
            this.Close();
        }
    }
}
