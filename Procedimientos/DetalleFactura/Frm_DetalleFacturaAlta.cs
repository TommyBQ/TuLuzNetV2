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

namespace TuLuzNet.Procedimientos.DetalleFactura
{
    public partial class Frm_DetalleFacturaAlta : Form
    {
        Ne_DetalleFactura neg_detFactura = new Ne_DetalleFactura();
        public Frm_DetalleFacturaAlta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales _TE = new TratamientosEspeciales();
            if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[DetalleFactura]"))
            {
                neg_detFactura.AltaDetalleFactura(this.Controls); //aca se mandan todos los txtbox cmbbox
            }
            this.Close();
        }
    }
}
