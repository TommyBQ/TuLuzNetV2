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
using Microsoft.Reporting.WinForms;

namespace TuLuzNet.Reportes.ClientesXActivo
{
    public partial class Frm_Rep_CliXActivo : Form
    {
        Ne_Clientes _NC = new Ne_Clientes();
        public Frm_Rep_CliXActivo()
        {
            InitializeComponent();
        }

        private void Frm_Rep_CliXActivo_Load(object sender, EventArgs e)
        {

            this.rv_cxa.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string estado = "";
            if (rb_activo.Checked)
            {
                tabla = _NC.RecuperarTodosClientesXActivo(1);
                estado = "Activos";
            }
            else if (rb_noActivo.Checked)
            {
                tabla = _NC.RecuperarTodosClientesXActivo(0);
                estado = "No Activos";
            }
            else
            {
                MessageBox.Show("No se seleccionaron parámetros de búsqueda!");
                return;
            }

            ReportDataSource datos = new ReportDataSource("DataSet1",tabla);
            rv_cxa.LocalReport.ReportEmbeddedResource = "TuLuzNet.Reportes.ClientesXActivo.Rpt_CliXActivo.rdlc";
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RParametro", "Para los Clientes " + estado);
            rv_cxa.LocalReport.SetParameters(parametro);
            rv_cxa.LocalReport.DataSources.Clear();
            rv_cxa.LocalReport.DataSources.Add(datos);
            rv_cxa.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal frm_PaginaPrincipal = new Frm_PaginaPrincipal();
            frm_PaginaPrincipal.Show();
        }
    }
}
