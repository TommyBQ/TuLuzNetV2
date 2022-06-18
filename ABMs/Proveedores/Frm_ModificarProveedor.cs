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

namespace TuLuzNet.ABMs.Proveedores
{
    public partial class Frm_ModificarProveedor : Form
    {
        public string _cuit { get; set; }

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Proveedores _NE = new Ne_Proveedores();
        public Frm_ModificarProveedor()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ModificarProveedor_Load(object sender, EventArgs e)
        {
            this.RecuperarProveedor();
        }

        private void RecuperarProveedor()
        {
            DataTable Tabla = new DataTable();
            Tabla = _NE.RecuperarProveedorXCUIT(_cuit);
            _TE.CargarFormulario(this.Controls, Tabla);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == true)
            {
                _NE.cuit = this.txtIDProveedor.Text;
                _NE.contacto = this.txtContacto.Text;
                _NE.razon_social = this.txtRazonSocial.Text;
                _NE.telefono = this.txtTelefono.Text;
                _NE.activo = this.chkBoxActivo.Checked;

                _NE.Modificar();
            }
            this.Close();
        }
    }
}
