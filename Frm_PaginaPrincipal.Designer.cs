﻿
namespace TuLuzNet
{
    partial class Frm_PaginaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.lblTuLuz = new System.Windows.Forms.Label();
            this.lblABM = new System.Windows.Forms.Label();
            this.btnProvincia = new System.Windows.Forms.Button();
            this.btnTipoDocumento = new System.Windows.Forms.Button();
            this.btnLocalidad = new System.Windows.Forms.Button();
            this.btnBarrio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarPedido = new System.Windows.Forms.Button();
            this.btnCargarCotizacion = new System.Windows.Forms.Button();
            this.btnCargarFactura = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReportesXActivos = new System.Windows.Forms.Button();
            this.btnCotizacionesXEmpleado = new System.Windows.Forms.Button();
            this.btnEmpleadosXActivo = new System.Windows.Forms.Button();
            this.btnCotizacionesXPrecio = new System.Windows.Forms.Button();
            this.btnPedidosEntrePrecios = new System.Windows.Forms.Button();
            this.btnPedidoEntreFechas = new System.Windows.Forms.Button();
            this.btnPedidosXEmpleado = new System.Windows.Forms.Button();
            this.btnPedidosXCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(16, 90);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(131, 40);
            this.btnProveedores.TabIndex = 0;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(153, 90);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(131, 40);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(16, 135);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(131, 40);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(153, 135);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(131, 40);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // lblTuLuz
            // 
            this.lblTuLuz.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTuLuz.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblTuLuz.Location = new System.Drawing.Point(0, 0);
            this.lblTuLuz.Name = "lblTuLuz";
            this.lblTuLuz.Size = new System.Drawing.Size(960, 39);
            this.lblTuLuz.TabIndex = 8;
            this.lblTuLuz.Text = "TuLuz";
            this.lblTuLuz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTuLuz.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblABM
            // 
            this.lblABM.AutoSize = true;
            this.lblABM.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblABM.Location = new System.Drawing.Point(10, 55);
            this.lblABM.Name = "lblABM";
            this.lblABM.Size = new System.Drawing.Size(78, 32);
            this.lblABM.TabIndex = 9;
            this.lblABM.Text = "ABMs";
            // 
            // btnProvincia
            // 
            this.btnProvincia.Location = new System.Drawing.Point(16, 225);
            this.btnProvincia.Name = "btnProvincia";
            this.btnProvincia.Size = new System.Drawing.Size(131, 40);
            this.btnProvincia.TabIndex = 10;
            this.btnProvincia.Text = "Provincia";
            this.btnProvincia.UseVisualStyleBackColor = true;
            this.btnProvincia.Click += new System.EventHandler(this.btnProvincia_Click);
            // 
            // btnTipoDocumento
            // 
            this.btnTipoDocumento.Location = new System.Drawing.Point(153, 225);
            this.btnTipoDocumento.Name = "btnTipoDocumento";
            this.btnTipoDocumento.Size = new System.Drawing.Size(131, 40);
            this.btnTipoDocumento.TabIndex = 11;
            this.btnTipoDocumento.Text = "TipoDocumento";
            this.btnTipoDocumento.UseVisualStyleBackColor = true;
            this.btnTipoDocumento.Click += new System.EventHandler(this.btnTipoDocumento_Click);
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.Location = new System.Drawing.Point(153, 180);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(131, 40);
            this.btnLocalidad.TabIndex = 12;
            this.btnLocalidad.Text = "Localidad";
            this.btnLocalidad.UseVisualStyleBackColor = true;
            this.btnLocalidad.Click += new System.EventHandler(this.btnLocalidad_Click);
            // 
            // btnBarrio
            // 
            this.btnBarrio.Location = new System.Drawing.Point(16, 180);
            this.btnBarrio.Name = "btnBarrio";
            this.btnBarrio.Size = new System.Drawing.Size(131, 40);
            this.btnBarrio.TabIndex = 13;
            this.btnBarrio.Text = "Barrio";
            this.btnBarrio.UseVisualStyleBackColor = true;
            this.btnBarrio.Click += new System.EventHandler(this.btnBarrio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(875, 298);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 25);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(344, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Procedimientos";
            // 
            // btnCargarPedido
            // 
            this.btnCargarPedido.Location = new System.Drawing.Point(350, 90);
            this.btnCargarPedido.Name = "btnCargarPedido";
            this.btnCargarPedido.Size = new System.Drawing.Size(131, 40);
            this.btnCargarPedido.TabIndex = 16;
            this.btnCargarPedido.Text = "Cargar Pedido";
            this.btnCargarPedido.UseVisualStyleBackColor = true;
            this.btnCargarPedido.Click += new System.EventHandler(this.btnCargarPedido_Click);
            // 
            // btnCargarCotizacion
            // 
            this.btnCargarCotizacion.Location = new System.Drawing.Point(486, 90);
            this.btnCargarCotizacion.Name = "btnCargarCotizacion";
            this.btnCargarCotizacion.Size = new System.Drawing.Size(131, 40);
            this.btnCargarCotizacion.TabIndex = 17;
            this.btnCargarCotizacion.Text = "Cargar Cotización";
            this.btnCargarCotizacion.UseVisualStyleBackColor = true;
            this.btnCargarCotizacion.Click += new System.EventHandler(this.btnCargarCotizacion_Click);
            // 
            // btnCargarFactura
            // 
            this.btnCargarFactura.Location = new System.Drawing.Point(350, 135);
            this.btnCargarFactura.Name = "btnCargarFactura";
            this.btnCargarFactura.Size = new System.Drawing.Size(131, 40);
            this.btnCargarFactura.TabIndex = 18;
            this.btnCargarFactura.Text = "Cargar Factura";
            this.btnCargarFactura.UseVisualStyleBackColor = true;
            this.btnCargarFactura.Click += new System.EventHandler(this.btnCargarFactura_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(672, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Reportes";
            // 
            // btnReportesXActivos
            // 
            this.btnReportesXActivos.Location = new System.Drawing.Point(678, 90);
            this.btnReportesXActivos.Name = "btnReportesXActivos";
            this.btnReportesXActivos.Size = new System.Drawing.Size(131, 40);
            this.btnReportesXActivos.TabIndex = 20;
            this.btnReportesXActivos.Text = "Reportes Por Activos";
            this.btnReportesXActivos.UseVisualStyleBackColor = true;
            this.btnReportesXActivos.Click += new System.EventHandler(this.btnReportesXActivos_Click);
            // 
            // btnCotizacionesXEmpleado
            // 
            this.btnCotizacionesXEmpleado.Location = new System.Drawing.Point(814, 90);
            this.btnCotizacionesXEmpleado.Name = "btnCotizacionesXEmpleado";
            this.btnCotizacionesXEmpleado.Size = new System.Drawing.Size(131, 40);
            this.btnCotizacionesXEmpleado.TabIndex = 21;
            this.btnCotizacionesXEmpleado.Text = "Cotizaciones por Empleado";
            this.btnCotizacionesXEmpleado.UseVisualStyleBackColor = true;
            this.btnCotizacionesXEmpleado.Click += new System.EventHandler(this.btnCotizacionesXEmpleado_Click);
            // 
            // btnEmpleadosXActivo
            // 
            this.btnEmpleadosXActivo.Location = new System.Drawing.Point(814, 135);
            this.btnEmpleadosXActivo.Name = "btnEmpleadosXActivo";
            this.btnEmpleadosXActivo.Size = new System.Drawing.Size(131, 40);
            this.btnEmpleadosXActivo.TabIndex = 23;
            this.btnEmpleadosXActivo.Text = "Empleados por Activo";
            this.btnEmpleadosXActivo.UseVisualStyleBackColor = true;
            // 
            // btnCotizacionesXPrecio
            // 
            this.btnCotizacionesXPrecio.Location = new System.Drawing.Point(678, 135);
            this.btnCotizacionesXPrecio.Name = "btnCotizacionesXPrecio";
            this.btnCotizacionesXPrecio.Size = new System.Drawing.Size(131, 40);
            this.btnCotizacionesXPrecio.TabIndex = 22;
            this.btnCotizacionesXPrecio.Text = "Cotizaciones por Precio";
            this.btnCotizacionesXPrecio.UseVisualStyleBackColor = true;
            // 
            // btnPedidosEntrePrecios
            // 
            this.btnPedidosEntrePrecios.Location = new System.Drawing.Point(814, 180);
            this.btnPedidosEntrePrecios.Name = "btnPedidosEntrePrecios";
            this.btnPedidosEntrePrecios.Size = new System.Drawing.Size(131, 40);
            this.btnPedidosEntrePrecios.TabIndex = 25;
            this.btnPedidosEntrePrecios.Text = "Pedidos entre Precios";
            this.btnPedidosEntrePrecios.UseVisualStyleBackColor = true;
            // 
            // btnPedidoEntreFechas
            // 
            this.btnPedidoEntreFechas.Location = new System.Drawing.Point(678, 180);
            this.btnPedidoEntreFechas.Name = "btnPedidoEntreFechas";
            this.btnPedidoEntreFechas.Size = new System.Drawing.Size(131, 40);
            this.btnPedidoEntreFechas.TabIndex = 24;
            this.btnPedidoEntreFechas.Text = "Pedido entre Fechas";
            this.btnPedidoEntreFechas.UseVisualStyleBackColor = true;
            // 
            // btnPedidosXEmpleado
            // 
            this.btnPedidosXEmpleado.Location = new System.Drawing.Point(814, 225);
            this.btnPedidosXEmpleado.Name = "btnPedidosXEmpleado";
            this.btnPedidosXEmpleado.Size = new System.Drawing.Size(131, 40);
            this.btnPedidosXEmpleado.TabIndex = 27;
            this.btnPedidosXEmpleado.Text = "Pedidos por Empleado";
            this.btnPedidosXEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnPedidosXCliente
            // 
            this.btnPedidosXCliente.Location = new System.Drawing.Point(678, 225);
            this.btnPedidosXCliente.Name = "btnPedidosXCliente";
            this.btnPedidosXCliente.Size = new System.Drawing.Size(131, 40);
            this.btnPedidosXCliente.TabIndex = 26;
            this.btnPedidosXCliente.Text = "Pedidos por Cliente";
            this.btnPedidosXCliente.UseVisualStyleBackColor = true;
            // 
            // Frm_PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 335);
            this.Controls.Add(this.btnPedidosXEmpleado);
            this.Controls.Add(this.btnPedidosXCliente);
            this.Controls.Add(this.btnPedidosEntrePrecios);
            this.Controls.Add(this.btnPedidoEntreFechas);
            this.Controls.Add(this.btnEmpleadosXActivo);
            this.Controls.Add(this.btnCotizacionesXPrecio);
            this.Controls.Add(this.btnCotizacionesXEmpleado);
            this.Controls.Add(this.btnReportesXActivos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCargarFactura);
            this.Controls.Add(this.btnCargarCotizacion);
            this.Controls.Add(this.btnCargarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBarrio);
            this.Controls.Add(this.btnLocalidad);
            this.Controls.Add(this.btnTipoDocumento);
            this.Controls.Add(this.btnProvincia);
            this.Controls.Add(this.lblABM);
            this.Controls.Add(this.lblTuLuz);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnProveedores);
            this.Name = "Frm_PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuLuz";
            this.Load += new System.EventHandler(this.Frm_PaginaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label lblTuLuz;
        private System.Windows.Forms.Label lblABM;
        private System.Windows.Forms.Button btnProvincia;
        private System.Windows.Forms.Button btnTipoDocumento;
        private System.Windows.Forms.Button btnLocalidad;
        private System.Windows.Forms.Button btnBarrio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarPedido;
        private System.Windows.Forms.Button btnCargarCotizacion;
        private System.Windows.Forms.Button btnCargarFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReportesXActivos;
        private System.Windows.Forms.Button btnCotizacionesXEmpleado;
        private System.Windows.Forms.Button btnEmpleadosXActivo;
        private System.Windows.Forms.Button btnCotizacionesXPrecio;
        private System.Windows.Forms.Button btnPedidosEntrePrecios;
        private System.Windows.Forms.Button btnPedidoEntreFechas;
        private System.Windows.Forms.Button btnPedidosXEmpleado;
        private System.Windows.Forms.Button btnPedidosXCliente;
    }
}
