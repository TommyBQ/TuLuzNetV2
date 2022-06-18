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
//using TuLuzNet.Negocio.Ne_TipoDocumento;



namespace TuLuzNet.ABMs.TipoDocumento
{
    public partial class Frm_AltaTipoDocumento : Form
    {
        Negocio.Ne_TipoDocumento _NTD = new Ne_TipoDocumento();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public Frm_AltaTipoDocumento()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ne_TipoDocumento _NTP = new Ne_TipoDocumento();

            //_NTP.nombre = this.txtNombre.Text;
            //_NTP.siglas = this.txtSiglas.Text;
            //_NTP.AltaTipoDocumento();

            //MessageBox.Show("Se guardó correctamente!");
            //this.Close();
            if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[TipoDocumento]"))
            {
                _NTD.AltaTipoDocumento(this.Controls); //aca se mandan todos los txtbox cmbbox
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
