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
    public partial class Frm_AltaBarrios : Form
    {
        Ne_Barrios barrios = new Ne_Barrios();
        public Frm_AltaBarrios()
        {
            InitializeComponent();
            
        }

        private void Frm_AltaBarrios_Load(object sender, EventArgs e)
        {
            cmb_localidades.Cargar(barrios.DatosCombo());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[Barrio]"))
            {
                barrios.AltaBarrios(this.Controls); //aca se mandan todos los txtbox cmbbox
            }
            this.Close();
        }

        private void cmb_localidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
