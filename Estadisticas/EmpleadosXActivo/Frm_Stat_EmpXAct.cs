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

namespace TuLuzNet.Estadisticas.EmpleadosXActivo
{
    public partial class Frm_Stat_EmpXAct : Form
    {
        Ne_Empleados _NE = new Ne_Empleados();
        public Frm_Stat_EmpXAct()
        {
            InitializeComponent();
        }

        private void Frm_Stat_EmpXAct_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = _NE.RecuperarCantEmpleadosActivos();

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TuLuzNet.Estadisticas.EmpleadosXActivo.Stat_EmpXActivo.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }
    }
}
