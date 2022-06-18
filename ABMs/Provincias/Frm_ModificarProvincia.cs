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

namespace TuLuzNet.ABMs.Provincias
{
    public partial class Frm_ModificarProvincia : Form
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Provincias _NP = new Ne_Provincias();
        public string codProvincia { get; set; }

        public Frm_ModificarProvincia()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == true)
            {
                _NP.nombreNuevo = this.txt_nombre.Text;
                _NP.Modificar();
            }
            this.Close();
        }

        private void Frm_ModificarProvincia_Load(object sender, EventArgs e)
        {
            this.RecuperarProvincia();
        }


        private void RecuperarProvincia()
        {
            DataTable tabla = new DataTable();
            tabla = _NP.RecuperaProvinciaXid(codProvincia);
            _TE.CargarFormulario(this.Controls, tabla);
            _NP.nombreAnterior = this.txt_nombre.Text;
        }
    }
}
