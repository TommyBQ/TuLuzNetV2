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

namespace TuLuzNet.Reportes.CotizacionesXEmpleado
{
    public partial class Frm_Rep_CotXEmpleado : Form
    {
        Ne_Empleados _Ne = new Ne_Empleados();
        Ne_Cotizaciones _Nc = new Ne_Cotizaciones();
        public Frm_Rep_CotXEmpleado()
        {
            InitializeComponent();
        }

        private void Frm_Rep_CotXEmpleado_Load(object sender, EventArgs e)
        {
            this.cmbCuit.Cargar(_Ne.DatosComboDoc());
        }

        private void cmbCuit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCuit.SelectedValue.ToString() != "")
            {
                DataTable tabla = new DataTable();
                tabla = _Ne.RecuperarEmpleados("","",cmbCuit.SelectedValue.ToString());
                _Ne.RecargarEmpleado(this.Controls, tabla);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cmbCuit.SelectedValue is null)
                return;
            DataTable tabla = new DataTable();
            tabla = _Nc.BuscarCotXVendedor(cmbCuit.SelectedValue.ToString());
            string apellido = txtApeEmpleado.Text;
            string nombre = txtNomEmpleado.Text;

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv_cxe.LocalReport.ReportEmbeddedResource = "TuLuzNet.Reportes.CotizacionesXEmpleado.Rpt_CotXEmpleado.rdlc";
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RParametro", "Para el Empleado: " + apellido + ", " + nombre);
            rv_cxe.LocalReport.SetParameters(parametro);
            rv_cxe.LocalReport.DataSources.Clear();
            rv_cxe.LocalReport.DataSources.Add(datos);
            rv_cxe.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal frm_PaginaPrincipal = new Frm_PaginaPrincipal();
            frm_PaginaPrincipal.Show();
        }
    }
}
