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

namespace TuLuzNet.Reportes.PedidosEntrePrecio
{
    public partial class Frm_Rep_PedidoXPrecio : Form
    {
        Ne_Pedidos _NP = new Ne_Pedidos();
        public Frm_Rep_PedidoXPrecio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtPrecioMin.Text == "" || this.txtPrecioMax.Text == "")
            {
                MessageBox.Show("No se ingresó valor mínimo o máximo.");
                return;
            }
            DataTable tabla = new DataTable();
            tabla = _NP.RecuperarPedidoEntrePrecio(txtPrecioMin.Text, txtPrecioMax.Text);

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rvPedXPrecio.LocalReport.ReportEmbeddedResource = "TuLuzNet.Reportes.PedidosEntrePrecio.Rpt_PedXPrecio.rdlc";
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RParametro", "Para el pedido entre: $" + txtPrecioMin.Text + " y $" + txtPrecioMax.Text);
            rvPedXPrecio.LocalReport.SetParameters(parametro);
            rvPedXPrecio.LocalReport.DataSources.Clear();
            rvPedXPrecio.LocalReport.DataSources.Add(datos);
            rvPedXPrecio.RefreshReport();
        }

        private void Frm_Rep_PedidoXPrecio_Load(object sender, EventArgs e)
        {
            this.rvPedXPrecio.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal frm_PaginaPrincipal = new Frm_PaginaPrincipal();
            frm_PaginaPrincipal.Show();
        }
    }
}
