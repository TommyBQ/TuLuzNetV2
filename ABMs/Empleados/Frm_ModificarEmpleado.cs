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

namespace TuLuzNet.ABMs.Empleados
{
    public partial class Frm_ModificarEmpleado : Form
    {
        public string _telefono { get; set; }

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Empleados _NE = new Ne_Empleados();
        Ne_Barrios _NB = new Ne_Barrios();
        public Frm_ModificarEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ModificarEmpleado_Load(object sender, EventArgs e)
        {
            cmbTDoc.Cargar(_NE.DatosCombo());
            cmbBarrio.Cargar(_NB.DatosCombo());
            cmbTDocJefe.Cargar(_NE.DatosCombo());
            this.RecuperarEmpleado();
        }

        private void RecuperarEmpleado()
        {
            DataTable Tabla = new DataTable();
            Tabla = _NE.RecuperarUsuarioXTelefono(_telefono);
            _TE.CargarFormulario(this.Controls, Tabla);
            //this.txt.Text = Tabla.Rows[0]["id_usuario"].ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls)==true)
            {
                _NE.tipoDoc = (int)this.cmbTDoc.SelectedValue; //OJO
                _NE.numDoc = int.Parse(this.txtNDoc.Text);
                _NE.nombre = this.txtNombre.Text;
                _NE.apellido = this.txtApellido.Text;
                _NE.direccion = this.txtDireccion.Text;
                _NE.codBarrio = (int)this.cmbBarrio.SelectedValue;
                _NE.telefono = this.txtTelefono.Text;
                if (this.cmbTDocJefe.SelectedValue != null)
                {
                    _NE.tipoDocJefe = (int)this.cmbTDocJefe.SelectedValue; //OJO
                    _NE.numDocJefe = int.Parse(this.txtNDocJefe.Text);
                }
                else
                {
                    _NE.tipoDocJefe = -1;
                    _NE.numDocJefe = -1;
                }
                //_NE.tipoDocJefe = (int)this.cmbTDocJefe.SelectedValue; //OJO
                //_NE.numDocJefe = int.Parse(this.txtNDocJefe.Text);
                _NE.activo = this.ckbActivo.Checked;

                _NE.Modificar();
            }
            this.Close();
        }
    }
}
