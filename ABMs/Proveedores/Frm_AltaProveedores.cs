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
    public partial class Frm_AltaProveedores : Form
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Proveedores _NE = new Ne_Proveedores();
        public Frm_AltaProveedores()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Frm_AltaProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[Proveedor]"))
            {
                _NE.AltaProveedor(this.Controls); //aca se mandan todos los txtbox cmbbox
            }
        }
    }
}
