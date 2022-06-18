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

namespace TuLuzNet.ABMs.TipoDocumento
{
    public partial class Frm_ModificarTipoDocumento : Form
    {

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_TipoDocumento _NTD = new Ne_TipoDocumento();

        public string idTipoDocumento { get; set; }
        public Frm_ModificarTipoDocumento()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == true)
            {
                _NTD.nombre = this.txt_Nombre.Text;
                _NTD.siglas = this.txt_Siglas.Text;
                _NTD.Modificar();
            }
            this.Close();
        }

        private void Frm_ModificarTipoDocumento_Load(object sender, EventArgs e)
        {
            this.RecuperarTipoDocumento();
        }

        private void RecuperarTipoDocumento()
        {
            DataTable tabla = new DataTable();
            tabla = _NTD.RecuperarTipoDocumentoXid(idTipoDocumento);
            _TE.CargarFormulario(this.Controls, tabla);
            _NTD.nombreAnterior = this.txt_Nombre.Text;
        }
    }
}
