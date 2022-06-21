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

namespace TuLuzNet.Estadisticas.ProductosMasVendidosXAño
{
    public partial class Frm_Stats_ProdMasVendidosXAño : Form
    {
        Ne_Productos _NP = new Ne_Productos();
        public Frm_Stats_ProdMasVendidosXAño()
        {
            InitializeComponent();
        }

        private void Frm_Stats_ProdMasVendidosXAño_Load(object sender, EventArgs e)
        {

            this.rvProd.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal frm_PaginaPrincipal = new Frm_PaginaPrincipal();
            frm_PaginaPrincipal.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtAño.Text == "")
            {
                MessageBox.Show("No se ingresó año.");
                return;
            }
            DataTable tabla = new DataTable();
            tabla = _NP.RecuperarProductosXAño(txtAño.Text);

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rvProd.LocalReport.ReportEmbeddedResource = "TuLuzNet.Estadisticas.ProductosMasVendidosXAño.Stats_ProdMasVendidoXAño.rdlc";
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RParameter", txtAño.Text);
            rvProd.LocalReport.SetParameters(parametro);
            rvProd.LocalReport.DataSources.Clear();
            rvProd.LocalReport.DataSources.Add(datos);
            rvProd.RefreshReport();
        }
    }
}
