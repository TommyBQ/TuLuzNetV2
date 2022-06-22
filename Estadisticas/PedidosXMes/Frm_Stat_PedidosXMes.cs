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

namespace TuLuzNet.Estadisticas.PedidosXMes
{
    public partial class Frm_Stat_PedidosXMes : Form
    {
        Ne_Pedidos _NP = new Ne_Pedidos();
        public Frm_Stat_PedidosXMes()
        {
            InitializeComponent();
        }

        private void Frm_Stat_PedidosXMes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = _NP.RecuperarPedidosXMes();

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TuLuzNet.Estadisticas.PedidosXMes.Stat_PedXMes.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }
    }
}
