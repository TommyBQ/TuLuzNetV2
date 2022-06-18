using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.Negocio;

namespace TuLuzNet.ABMs.Provincias
{
    public partial class Frm_AltaProvincias : Form
    {
        public Frm_AltaProvincias()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ne_Provincias neg_provincias = new Ne_Provincias();

            neg_provincias.nombre = this.txtNombre.Text;
            neg_provincias.Insertar();

            MessageBox.Show("Se guardó correctamente!");
            this.Close();
        }
    }
}
