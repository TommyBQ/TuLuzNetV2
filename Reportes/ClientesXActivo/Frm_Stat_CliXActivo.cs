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

namespace TuLuzNet.Reportes.ClientesXActivo
{
    public partial class Frm_Stat_CliXActivo : Form
    {
        Ne_Clientes _Nc = new Ne_Clientes();
        public Frm_Stat_CliXActivo()
        {
            InitializeComponent();
        }

        private void Frm_Stat_CliXActivo_Load(object sender, EventArgs e)
        {
            this.rv_scxa.RefreshReport();
        }

        private void rv_scxa_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = _Nc.RecuperarCantClientesActivos();

            ReportDataSource datos = new ReportDataSource("DatosStatCli", tabla);
            rv_scxa.LocalReport.ReportEmbeddedResource = "TuLuzNet.Reportes.ClientesXActivo.Stat_CliXActivo.rdlc";
            rv_scxa.LocalReport.DataSources.Clear();
            rv_scxa.LocalReport.DataSources.Add(datos);
            rv_scxa.RefreshReport();
        }
    }
}
