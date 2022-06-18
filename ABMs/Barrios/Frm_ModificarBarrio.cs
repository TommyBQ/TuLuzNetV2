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

namespace TuLuzNet.ABMs.Barrios
{
    public partial class Frm_ModificarBarrio : Form
    {
        int localidadBario;
        public string idBarrio { get; set; }

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Barrios _NB = new Ne_Barrios();



        public Frm_ModificarBarrio()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ModificarBarrio_Load(object sender, EventArgs e)
        {
            cmb_localidades1.Cargar(_NB.DatosCombo());
            this.RecuperarBarrio();
        }

        private void RecuperarBarrio()
        {
            DataTable tabla = new DataTable();
            tabla = _NB.RecuperarBarrioXid(idBarrio);
            _TE.CargarFormulario(this.Controls, tabla);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Barrio] SET nombre = 'BPQ1', codLocalidad = 3 WHERE codBarrio = 13;
            if (_TE.Validar(this.Controls) == true)
            {
                _NB._idBarrio = int.Parse(this.txtCodigoBarrio.Text);
                _NB._nombreBarrio = this.txtNombre.Text;
                _NB._localidadBarrio = Convert.ToInt32(this.cmb_localidades1.SelectedValue);
                _NB.Modificar();
            }
            this.Close();
        }
    }
}
