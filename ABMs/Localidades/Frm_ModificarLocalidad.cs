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


namespace TuLuzNet.ABMs.Localidades
{
    public partial class Frm_ModificarLocalidad : Form
    {
        public string idLocalidad { get; set; }

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Localidad _NL = new Ne_Localidad();

        public Frm_ModificarLocalidad()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ModificarLocalidad_Load(object sender, EventArgs e)
        {
            //Ne_Localidad localidades = new Ne_Localidad();
            cmb_provincias.Cargar(_NL.DatosCombo());
            this.RecuperarLocalidad();
        }

        private void RecuperarLocalidad()
        {
            DataTable tabla = new DataTable();
            tabla = _NL.RecuperarLocalidadXid(idLocalidad);
            _TE.CargarFormulario(this.Controls, tabla);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == true)
            {
                _NL._idLocalidad = int.Parse(this.txt_localidad.Text);
                _NL._nombreLocalidad = this.txt_nombre.Text;
                _NL._codProvincia = Convert.ToInt32(this.cmb_provincias.SelectedValue);
                _NL.Modificar();
            }
            this.Close();
        }
    }
}
