using Microsoft.Reporting.WinForms;
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

namespace TuLuzNet.Reportes.CotizacionesEntrePrecio
{
    public partial class Frm_Rep_CotEntrePrecios : Form
    {
        Ne_Cotizaciones _NC = new Ne_Cotizaciones();
        public Frm_Rep_CotEntrePrecios()
        {
            InitializeComponent();
        }

        private void Frm_Rep_CotEntrePrecios_Load(object sender, EventArgs e)
        {
            this.rvCotXPrecios.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal frm_PaginaPrincipal = new Frm_PaginaPrincipal();
            frm_PaginaPrincipal.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtPrecioMin.Text == "" || this.txtPrecioMax.Text == "")
            {
                MessageBox.Show("No se ingresó valor mínimo o máximo.");
                return;
            }
            DataTable tabla = new DataTable();
            tabla = _NC.RecuperarCotizacionXPrecio(txtPrecioMin.Text, txtPrecioMax.Text);

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rvCotXPrecios.LocalReport.ReportEmbeddedResource = "TuLuzNet.Reportes.CotizacionesEntrePrecio.Rpt_CotXPrecio.rdlc";
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RParametro", "Para la cotizacion entre: $" + txtPrecioMin.Text + " y $" + txtPrecioMax.Text);
            rvCotXPrecios.LocalReport.SetParameters(parametro);
            rvCotXPrecios.LocalReport.DataSources.Clear();
            rvCotXPrecios.LocalReport.DataSources.Add(datos);
            rvCotXPrecios.RefreshReport();
        }
    }
}
