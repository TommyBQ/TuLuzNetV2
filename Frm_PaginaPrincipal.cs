﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.ABMs;
using TuLuzNet.Procedimientos.Factura;
using TuLuzNet.Procedimientos.Cotizaciones;
using TuLuzNet.ABMs.Pedidos;
using TuLuzNet.Reportes.ClientesXActivo;
using TuLuzNet.Reportes.CotizacionesXEmpleado;
using TuLuzNet.Reportes.EmpleadosXActivo;
using TuLuzNet.Reportes.CotizacionesEntrePrecio;

namespace TuLuzNet
{
    public partial class Frm_PaginaPrincipal : Form
    {
        public Frm_PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Proveedores formABMProveedores = new Frm_ABM_Proveedores();
            formABMProveedores.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Empleados formABMEmpleados = new Frm_ABM_Empleados();
            formABMEmpleados.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Clientes formABMClientes = new Frm_ABM_Clientes();
            formABMClientes.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Productos formABMProductos = new Frm_ABM_Productos();
            formABMProductos.Show();
        }

        private void Frm_PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnBarrio_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Barrios formABMBarrios = new Frm_ABM_Barrios();
            formABMBarrios.Show();
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Localidades formABMLocalidades = new Frm_ABM_Localidades();
            formABMLocalidades.Show();
        }

        private void btnProvincia_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Provincias formABMProvincia = new Frm_ABM_Provincias();
            formABMProvincia.Show();
        }

        private void btnTipoDocumento_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_TipoDocumentos formABMTipoDocumentos = new Frm_ABM_TipoDocumentos();
            formABMTipoDocumentos.Show();
        }

        private void btnCargarFactura_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_CargarFactura formFactura = new Frm_CargarFactura();
            formFactura.Show();
        }

        private void btnCargarPedido_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Pedidos frm_ABM_Pedidos = new Frm_ABM_Pedidos();
            frm_ABM_Pedidos.Show();
        }

        private void btnCargarCotizacion_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABMC_Cotizaciones formABMCPedidos = new Frm_ABMC_Cotizaciones();
            formABMCPedidos.Show();
        }

        private void btnReportesXActivos_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Rep_CliXActivo frm_Rep_CliXActivo = new Frm_Rep_CliXActivo();
            frm_Rep_CliXActivo.Show();
        }

        private void btnCotizacionesXEmpleado_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Rep_CotXEmpleado frm_Rep_CotXEmpleado = new Frm_Rep_CotXEmpleado();
            frm_Rep_CotXEmpleado.Show();
        }

        private void btnEmpleadosXActivo_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Rep_EmpXActivo frm_Rep_EmpXActivo = new Frm_Rep_EmpXActivo();
            frm_Rep_EmpXActivo.Show();
        }

        private void btnCotizacionesXPrecio_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Rep_CotEntrePrecios frm_Rep_CotEntrePrecios = new Frm_Rep_CotEntrePrecios();
            frm_Rep_CotEntrePrecios.Show();
        }
    }
}
