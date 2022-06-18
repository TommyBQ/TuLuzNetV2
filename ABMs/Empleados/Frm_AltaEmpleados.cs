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

namespace TuLuzNet.ABMs.Empleados
{
    public partial class Frm_AltaEmpleados : Form
    {
        Negocio.Ne_Empleados ne = new Negocio.Ne_Empleados();
        Negocio.Ne_Barrios neb = new Negocio.Ne_Barrios();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public Frm_AltaEmpleados()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[Empleados]"))
            {
                ne.AltaEmpleados(this.Controls); //aca se mandan todos los txtbox cmbbox
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_AltaEmpleados_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.Cargar(ne.DatosCombo());
            cmbBarrio.Cargar(neb.DatosCombo());
            cmbTipoDocJefe.Cargar(ne.DatosCombo());
        }
    }
}
