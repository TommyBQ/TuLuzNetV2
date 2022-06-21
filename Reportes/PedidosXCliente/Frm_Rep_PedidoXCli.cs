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

namespace TuLuzNet.Reportes.PedidosXCliente
{
    public partial class Frm_Rep_PedidoXCli : Form
    {
        Ne_Clientes _NC = new Ne_Clientes();
        Ne_Pedidos _NP = new Ne_Pedidos();
        public Frm_Rep_PedidoXCli()
        {
            InitializeComponent();
        }

        private void Frm_Rep_PedidoXCli_Load(object sender, EventArgs e)
        {
            cmbCuit.Cargar(_NC.DatosComboCuit());
            this.rvPedidos.RefreshReport();
        }

        private void cmbCuit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCuit.SelectedValue.ToString() != "")
            {
                DataTable tabla = new DataTable();
                tabla = _NC.RecuperaPedidoXCliente(cmbCuit.SelectedValue.ToString());
                _NC.RecargarCliente(this.Controls, tabla);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cmbCuit.SelectedValue is null)
                return;
            DataTable tabla = new DataTable();
            tabla = _NP.RecuperarPedidoXCliente(cmbCuit.SelectedValue.ToString());
            string apellido = txtApeEmpleado.Text;
            string nombre = txtNomEmpleado.Text;

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rvPedidos.LocalReport.ReportEmbeddedResource = "TuLuzNet.Reportes.PedidosXCliente.Rpt_PedidoXCli.rdlc";
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RParametro", "Para el cliente: " + apellido + ", " + nombre);
            rvPedidos.LocalReport.SetParameters(parametro);
            rvPedidos.LocalReport.DataSources.Clear();
            rvPedidos.LocalReport.DataSources.Add(datos);
            rvPedidos.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal frm_PaginaPrincipal = new Frm_PaginaPrincipal();
            frm_PaginaPrincipal.Show();
        }
    }
}
