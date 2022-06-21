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

namespace TuLuzNet.Reportes.EmpleadosXActivo
{
    public partial class Frm_Rep_EmpXActivo : Form
    {
        Ne_Empleados _NE = new Ne_Empleados();
        public Frm_Rep_EmpXActivo()
        {
            InitializeComponent();
        }

        private void Frm_Rep_EmpXActivo_Load(object sender, EventArgs e)
        {
            this.rvEmpXAct.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal frm_PaginaPrincipal = new Frm_PaginaPrincipal();
            frm_PaginaPrincipal.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string estado = "";
            if (rb_activo.Checked)
            {
                tabla = _NE.RecuperarTodosEmpleadosXActivo(1);
                estado = "Activos";
            }
            else if (rb_noActivo.Checked)
            {
                tabla = _NE.RecuperarTodosEmpleadosXActivo(0);
                estado = "No Activos";
            }
            else
            {
                MessageBox.Show("No se seleccionaron parámetros de búsqueda!");
                return;
            }

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rvEmpXAct.LocalReport.ReportEmbeddedResource = "TuLuzNet.Reportes.EmpleadosXActivo.Rpt_EmpXActivo.rdlc";
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RPARAM1", "Para los Empleados " + estado);
            rvEmpXAct.LocalReport.SetParameters(parametro);
            rvEmpXAct.LocalReport.DataSources.Clear();
            rvEmpXAct.LocalReport.DataSources.Add(datos);
            rvEmpXAct.RefreshReport();
        }
    }
}
