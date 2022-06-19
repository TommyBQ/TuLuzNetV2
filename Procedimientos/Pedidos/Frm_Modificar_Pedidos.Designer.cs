
namespace TuLuzNet.ABMs.Pedidos
{
    partial class Frm_Modificar_Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Pedidos));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.lblCondicionPago = new System.Windows.Forms.Label();
            this.cmbTDVendedor = new TuLuzNet.Clases.ComboBox01();
            this.txtDocVendedor = new TuLuzNet.Clases.TextBox01();
            this.lblTipoDocVendedor = new System.Windows.Forms.Label();
            this.lblNumDocVendedor = new System.Windows.Forms.Label();
            this.txtAñoCotizacion = new TuLuzNet.Clases.TextBox01();
            this.lblAñoCotizacion = new System.Windows.Forms.Label();
            this.txtNumCotizacion = new TuLuzNet.Clases.TextBox01();
            this.txtNumPedido = new TuLuzNet.Clases.TextBox01();
            this.lblNumCotizacion = new System.Windows.Forms.Label();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.lblModificarPedido = new System.Windows.Forms.Label();
            this.dtpFecha = new TuLuzNet.Clases.DateTimePicker01();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCuitCliente = new TuLuzNet.Clases.ComboBox01();
            this.txtCondPago = new TuLuzNet.Clases.TextBox01();
            this.dataGridViewDetallePed = new TuLuzNet.Clases.Grid01();
            this.btnAgregarDetallePed = new System.Windows.Forms.Button();
            this.btnBorrarDetallePed = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new TuLuzNet.Clases.TextBox01();
            this.cmbProducto = new TuLuzNet.Clases.ComboBox01();
            this.txtTotal = new TuLuzNet.Clases.TextBox01();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(603, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 29);
            this.btnCancelar.TabIndex = 112;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnModificarPedido.Location = new System.Drawing.Point(515, 335);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(84, 29);
            this.btnModificarPedido.TabIndex = 111;
            this.btnModificarPedido.Text = "Modificar";
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnModificarPedido_Click);
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCuitCliente.Location = new System.Drawing.Point(21, 242);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(90, 20);
            this.lblCuitCliente.TabIndex = 108;
            this.lblCuitCliente.Text = "CUIT Cliente";
            // 
            // lblCondicionPago
            // 
            this.lblCondicionPago.AutoSize = true;
            this.lblCondicionPago.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCondicionPago.Location = new System.Drawing.Point(20, 64);
            this.lblCondicionPago.Name = "lblCondicionPago";
            this.lblCondicionPago.Size = new System.Drawing.Size(134, 20);
            this.lblCondicionPago.TabIndex = 107;
            this.lblCondicionPago.Text = "Condicion de Pago";
            this.lblCondicionPago.Click += new System.EventHandler(this.lblCondicionPago_Click);
            // 
            // cmbTDVendedor
            // 
            this.cmbTDVendedor._columna = "tipoDniVendedor";
            this.cmbTDVendedor._MensajeError = "Hay un campo vacio";
            this.cmbTDVendedor._repetible = false;
            this.cmbTDVendedor._Validable = false;
            this.cmbTDVendedor.FormattingEnabled = true;
            this.cmbTDVendedor.Location = new System.Drawing.Point(159, 278);
            this.cmbTDVendedor.Name = "cmbTDVendedor";
            this.cmbTDVendedor.Size = new System.Drawing.Size(97, 21);
            this.cmbTDVendedor.TabIndex = 106;
            this.cmbTDVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTDVendedor_SelectedIndexChanged);
            // 
            // txtDocVendedor
            // 
            this.txtDocVendedor._columna = "numDniVendedor";
            this.txtDocVendedor._mensajeError = "Hay un campo vacio";
            this.txtDocVendedor._repetible = true;
            this.txtDocVendedor._validable = true;
            this.txtDocVendedor.Location = new System.Drawing.Point(134, 313);
            this.txtDocVendedor.Name = "txtDocVendedor";
            this.txtDocVendedor.Size = new System.Drawing.Size(122, 20);
            this.txtDocVendedor.TabIndex = 105;
            this.txtDocVendedor.TextChanged += new System.EventHandler(this.txtBoxDocVendedor_TextChanged);
            // 
            // lblTipoDocVendedor
            // 
            this.lblTipoDocVendedor.AutoSize = true;
            this.lblTipoDocVendedor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTipoDocVendedor.Location = new System.Drawing.Point(21, 277);
            this.lblTipoDocVendedor.Name = "lblTipoDocVendedor";
            this.lblTipoDocVendedor.Size = new System.Drawing.Size(141, 20);
            this.lblTipoDocVendedor.TabIndex = 104;
            this.lblTipoDocVendedor.Text = "Tipo Doc. Vendedor";
            this.lblTipoDocVendedor.Click += new System.EventHandler(this.lblTipoDocVendedor_Click);
            // 
            // lblNumDocVendedor
            // 
            this.lblNumDocVendedor.AutoSize = true;
            this.lblNumDocVendedor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNumDocVendedor.Location = new System.Drawing.Point(20, 313);
            this.lblNumDocVendedor.Name = "lblNumDocVendedor";
            this.lblNumDocVendedor.Size = new System.Drawing.Size(107, 20);
            this.lblNumDocVendedor.TabIndex = 103;
            this.lblNumDocVendedor.Text = "Doc. Vendedor";
            this.lblNumDocVendedor.Click += new System.EventHandler(this.lblNumDocVendedor_Click);
            // 
            // txtAñoCotizacion
            // 
            this.txtAñoCotizacion._columna = "añoCotizacion";
            this.txtAñoCotizacion._mensajeError = "Hay un campo vacio";
            this.txtAñoCotizacion._repetible = true;
            this.txtAñoCotizacion._validable = true;
            this.txtAñoCotizacion.Location = new System.Drawing.Point(134, 207);
            this.txtAñoCotizacion.Name = "txtAñoCotizacion";
            this.txtAñoCotizacion.ReadOnly = true;
            this.txtAñoCotizacion.Size = new System.Drawing.Size(122, 20);
            this.txtAñoCotizacion.TabIndex = 102;
            // 
            // lblAñoCotizacion
            // 
            this.lblAñoCotizacion.AutoSize = true;
            this.lblAñoCotizacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAñoCotizacion.Location = new System.Drawing.Point(21, 206);
            this.lblAñoCotizacion.Name = "lblAñoCotizacion";
            this.lblAñoCotizacion.Size = new System.Drawing.Size(110, 20);
            this.lblAñoCotizacion.TabIndex = 101;
            this.lblAñoCotizacion.Text = "Año Cotizacion";
            // 
            // txtNumCotizacion
            // 
            this.txtNumCotizacion._columna = "numeroCotizacion";
            this.txtNumCotizacion._mensajeError = "Hay un campo vacio";
            this.txtNumCotizacion._repetible = true;
            this.txtNumCotizacion._validable = true;
            this.txtNumCotizacion.Location = new System.Drawing.Point(134, 172);
            this.txtNumCotizacion.Name = "txtNumCotizacion";
            this.txtNumCotizacion.ReadOnly = true;
            this.txtNumCotizacion.Size = new System.Drawing.Size(122, 20);
            this.txtNumCotizacion.TabIndex = 100;
            // 
            // txtNumPedido
            // 
            this.txtNumPedido._columna = "numeroPedido";
            this.txtNumPedido._mensajeError = "Hay un campo vacio";
            this.txtNumPedido._repetible = true;
            this.txtNumPedido._validable = true;
            this.txtNumPedido.Location = new System.Drawing.Point(134, 136);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.ReadOnly = true;
            this.txtNumPedido.Size = new System.Drawing.Size(122, 20);
            this.txtNumPedido.TabIndex = 99;
            // 
            // lblNumCotizacion
            // 
            this.lblNumCotizacion.AutoSize = true;
            this.lblNumCotizacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNumCotizacion.Location = new System.Drawing.Point(21, 171);
            this.lblNumCotizacion.Name = "lblNumCotizacion";
            this.lblNumCotizacion.Size = new System.Drawing.Size(111, 20);
            this.lblNumCotizacion.TabIndex = 98;
            this.lblNumCotizacion.Text = "Nro. Cotizacion";
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNumPedido.Location = new System.Drawing.Point(21, 135);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(87, 20);
            this.lblNumPedido.TabIndex = 97;
            this.lblNumPedido.Text = "Nro. Pedido";
            // 
            // lblModificarPedido
            // 
            this.lblModificarPedido.AutoSize = true;
            this.lblModificarPedido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline);
            this.lblModificarPedido.Location = new System.Drawing.Point(10, 16);
            this.lblModificarPedido.Name = "lblModificarPedido";
            this.lblModificarPedido.Size = new System.Drawing.Size(196, 32);
            this.lblModificarPedido.TabIndex = 96;
            this.lblModificarPedido.Text = "Modificar Pedido";
            // 
            // dtpFecha
            // 
            this.dtpFecha._columna = "fechaPedido";
            this.dtpFecha._mensajeError = "no se q pasa con la fecha";
            this.dtpFecha._repetible = true;
            this.dtpFecha._validable = true;
            this.dtpFecha.CustomFormat = "dd MMMM yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(134, 101);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(122, 20);
            this.dtpFecha.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(21, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 138;
            this.label5.Text = "Fecha";
            // 
            // cmbCuitCliente
            // 
            this.cmbCuitCliente._columna = "cuitCliente";
            this.cmbCuitCliente._MensajeError = "No hay cuit seleccionado";
            this.cmbCuitCliente._repetible = false;
            this.cmbCuitCliente._Validable = true;
            this.cmbCuitCliente.FormattingEnabled = true;
            this.cmbCuitCliente.Location = new System.Drawing.Point(134, 243);
            this.cmbCuitCliente.Name = "cmbCuitCliente";
            this.cmbCuitCliente.Size = new System.Drawing.Size(122, 21);
            this.cmbCuitCliente.TabIndex = 140;
            // 
            // txtCondPago
            // 
            this.txtCondPago._columna = "condicionPago";
            this.txtCondPago._mensajeError = "Falta condicion PAGO!";
            this.txtCondPago._repetible = false;
            this.txtCondPago._validable = true;
            this.txtCondPago.Location = new System.Drawing.Point(151, 65);
            this.txtCondPago.Name = "txtCondPago";
            this.txtCondPago.Size = new System.Drawing.Size(105, 20);
            this.txtCondPago.TabIndex = 141;
            // 
            // dataGridViewDetallePed
            // 
            this.dataGridViewDetallePed.AllowUserToAddRows = false;
            this.dataGridViewDetallePed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetallePed.Location = new System.Drawing.Point(321, 79);
            this.dataGridViewDetallePed.Name = "dataGridViewDetallePed";
            this.dataGridViewDetallePed.RowHeadersVisible = false;
            this.dataGridViewDetallePed.RowTemplate.Height = 25;
            this.dataGridViewDetallePed.Size = new System.Drawing.Size(309, 208);
            this.dataGridViewDetallePed.TabIndex = 142;
            // 
            // btnAgregarDetallePed
            // 
            this.btnAgregarDetallePed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetallePed.BackgroundImage")));
            this.btnAgregarDetallePed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDetallePed.Location = new System.Drawing.Point(633, 36);
            this.btnAgregarDetallePed.Name = "btnAgregarDetallePed";
            this.btnAgregarDetallePed.Size = new System.Drawing.Size(39, 37);
            this.btnAgregarDetallePed.TabIndex = 143;
            this.btnAgregarDetallePed.UseVisualStyleBackColor = true;
            this.btnAgregarDetallePed.Click += new System.EventHandler(this.btnAgregarDetalleCot_Click);
            // 
            // btnBorrarDetallePed
            // 
            this.btnBorrarDetallePed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarDetallePed.BackgroundImage")));
            this.btnBorrarDetallePed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarDetallePed.Location = new System.Drawing.Point(633, 78);
            this.btnBorrarDetallePed.Name = "btnBorrarDetallePed";
            this.btnBorrarDetallePed.Size = new System.Drawing.Size(39, 37);
            this.btnBorrarDetallePed.TabIndex = 144;
            this.btnBorrarDetallePed.UseVisualStyleBackColor = true;
            this.btnBorrarDetallePed.Click += new System.EventHandler(this.btnBorrarDetalleCot_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label12.Location = new System.Drawing.Point(502, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 148;
            this.label12.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label10.Location = new System.Drawing.Point(321, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 147;
            this.label10.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad._columna = "cantidad";
            this.txtCantidad._mensajeError = "No seleccionó la cantidad";
            this.txtCantidad._repetible = false;
            this.txtCantidad._validable = false;
            this.txtCantidad.Location = new System.Drawing.Point(571, 45);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(43, 20);
            this.txtCantidad.TabIndex = 146;
            // 
            // cmbProducto
            // 
            this.cmbProducto._columna = "codProducto";
            this.cmbProducto._MensajeError = "No seleccionó Producto";
            this.cmbProducto._repetible = false;
            this.cmbProducto._Validable = false;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(393, 45);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(104, 21);
            this.cmbProducto.TabIndex = 145;
            // 
            // txtTotal
            // 
            this.txtTotal._columna = "precioTotal";
            this.txtTotal._mensajeError = "*";
            this.txtTotal._repetible = false;
            this.txtTotal._validable = false;
            this.txtTotal.Location = new System.Drawing.Point(459, 296);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(171, 20);
            this.txtTotal.TabIndex = 150;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCalcular.Location = new System.Drawing.Point(321, 292);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 28);
            this.btnCalcular.TabIndex = 151;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label11.Location = new System.Drawing.Point(416, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 149;
            this.label11.Text = "Total:";
            // 
            // Frm_Modificar_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 372);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.btnAgregarDetallePed);
            this.Controls.Add(this.btnBorrarDetallePed);
            this.Controls.Add(this.dataGridViewDetallePed);
            this.Controls.Add(this.txtCondPago);
            this.Controls.Add(this.cmbCuitCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.lblCuitCliente);
            this.Controls.Add(this.lblCondicionPago);
            this.Controls.Add(this.cmbTDVendedor);
            this.Controls.Add(this.txtDocVendedor);
            this.Controls.Add(this.lblTipoDocVendedor);
            this.Controls.Add(this.lblNumDocVendedor);
            this.Controls.Add(this.txtAñoCotizacion);
            this.Controls.Add(this.lblAñoCotizacion);
            this.Controls.Add(this.txtNumCotizacion);
            this.Controls.Add(this.txtNumPedido);
            this.Controls.Add(this.lblNumCotizacion);
            this.Controls.Add(this.lblNumPedido);
            this.Controls.Add(this.lblModificarPedido);
            this.Name = "Frm_Modificar_Pedidos";
            this.Text = "Modificar pedidos";
            this.Load += new System.EventHandler(this.Frm_Modificar_Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.Label lblCondicionPago;
        private Clases.ComboBox01 cmbTDVendedor;
        private Clases.TextBox01 txtDocVendedor;
        private System.Windows.Forms.Label lblTipoDocVendedor;
        private System.Windows.Forms.Label lblNumDocVendedor;
        private Clases.TextBox01 txtAñoCotizacion;
        private System.Windows.Forms.Label lblAñoCotizacion;
        private Clases.TextBox01 txtNumCotizacion;
        private Clases.TextBox01 txtNumPedido;
        private System.Windows.Forms.Label lblNumCotizacion;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.Label lblModificarPedido;
        private Clases.DateTimePicker01 dtpFecha;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBox01 cmbCuitCliente;
        private Clases.TextBox01 txtCondPago;
        private Clases.Grid01 dataGridViewDetallePed;
        private System.Windows.Forms.Button btnAgregarDetallePed;
        private System.Windows.Forms.Button btnBorrarDetallePed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Clases.TextBox01 txtCantidad;
        private Clases.ComboBox01 cmbProducto;
        private Clases.TextBox01 txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label11;
    }
}