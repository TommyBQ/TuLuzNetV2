using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TuLuzNet.Negocio;

namespace TuLuzNet.Reportes.CotizacionesXEmpleado
{
    public partial class Frm_Stat_CotXEmpleado : Form
    {
        Ne_Cotizaciones _Nc = new Ne_Cotizaciones();
        public Frm_Stat_CotXEmpleado()
        {
            InitializeComponent();
        }

        private void Frm_Stat_CotXEmpleado_Load(object sender, EventArgs e)
        {

            this.rv_scxe.RefreshReport();
        }

        private void rv_scxe_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = _Nc.RecuperarCantCotz();

            ReportDataSource datos = new ReportDataSource("DatosCotizaciones", tabla);
            rv_scxe.LocalReport.ReportEmbeddedResource = "TuLuzNet.Reportes.CotizacionesXEmpleado.Stat_CotXEmpleado.rdlc";
            rv_scxe.LocalReport.DataSources.Clear();
            rv_scxe.LocalReport.DataSources.Add(datos);
            rv_scxe.RefreshReport();
        }
    }
}
