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
    public partial class Frm_AltaLocalidades : Form
    {
        public Frm_AltaLocalidades()
        {
            InitializeComponent();
        }

        private void lblLocalidad_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ne_Localidad ne_localidad = new Ne_Localidad();
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[Localidad]"))
            {
                ne_localidad.AltaLocalidad(this.Controls); //aca se mandan todos los txtbox cmbbox
            }
            this.Close();

        }

        private void Frm_AltaLocalidades_Load(object sender, EventArgs e)
        {
            Ne_Localidad ne_localidad = new Ne_Localidad();
            cmb_provincias.Cargar(ne_localidad.DatosCombo());
        }
    }
}
