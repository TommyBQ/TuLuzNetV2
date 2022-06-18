﻿
namespace TuLuzNet.Procedimientos.Cotizaciones
{
    partial class Frm_AltaCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AltaCotizacion));
            this.txtNomCompetidor = new TuLuzNet.Clases.TextBox01();
            this.dtpFecha = new TuLuzNet.Clases.DateTimePicker01();
            this.txtNumero = new TuLuzNet.Clases.TextBox01();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new TuLuzNet.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApeCliente = new TuLuzNet.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomCliente = new TuLuzNet.Clases.TextBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoDocVendedor = new TuLuzNet.Clases.ComboBox01();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstado = new TuLuzNet.Clases.ComboBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCuitCliente = new TuLuzNet.Clases.ComboBox01();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotivoPerdida = new TuLuzNet.Clases.TextBox01();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservaciones = new TuLuzNet.Clases.TextBox01();
            this.lblMotivoPerdida = new System.Windows.Forms.Label();
            this.txtNumDocVendedor = new TuLuzNet.Clases.TextBox01();
            this.lblCompetidor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAño = new TuLuzNet.Clases.TextBox01();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblModificarEmpleado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new TuLuzNet.Clases.TextBox01();
            this.cmbProducto = new TuLuzNet.Clases.ComboBox01();
            this.btnAgregarDetalleCot = new System.Windows.Forms.Button();
            this.btnBorrarDetalleCot = new System.Windows.Forms.Button();
            this.dataGridViewDetalleCot = new TuLuzNet.Clases.Grid01();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleCot)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomCompetidor
            // 
            this.txtNomCompetidor._columna = "nomCompetidor";
            this.txtNomCompetidor._mensajeError = "No hay nombre de competidor";
            this.txtNomCompetidor._repetible = false;
            this.txtNomCompetidor._validable = false;
            this.txtNomCompetidor.Location = new System.Drawing.Point(148, 318);
            this.txtNomCompetidor.MaxLength = 50;
            this.txtNomCompetidor.Name = "txtNomCompetidor";
            this.txtNomCompetidor.Size = new System.Drawing.Size(142, 23);
            this.txtNomCompetidor.TabIndex = 161;
            this.txtNomCompetidor.Click += new System.EventHandler(this.txtNomCompetidor_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha._columna = "fecha";
            this.dtpFecha._mensajeError = "no se q pasa con la fecha";
            this.dtpFecha._repetible = true;
            this.dtpFecha._validable = true;
            this.dtpFecha.CustomFormat = "dd MMMM yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(490, 186);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(142, 23);
            this.dtpFecha.TabIndex = 168;
            // 
            // txtNumero
            // 
            this.txtNumero._columna = "numeroCotizacion";
            this.txtNumero._mensajeError = "El numero es autoincremental MAL ERROR";
            this.txtNumero._repetible = false;
            this.txtNumero._validable = false;
            this.txtNumero.Location = new System.Drawing.Point(148, 66);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(142, 23);
            this.txtNumero.TabIndex = 143;
            this.txtNumero.Text = "Automático.";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(16, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 20);
            this.lblNombre.TabIndex = 144;
            this.lblNombre.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 145;
            this.label1.Text = "Año";
            // 
            // txtTotal
            // 
            this.txtTotal._columna = "precioTotal";
            this.txtTotal._mensajeError = "Total calculable MAL ERROR";
            this.txtTotal._repetible = false;
            this.txtTotal._validable = true;
            this.txtTotal.Location = new System.Drawing.Point(490, 279);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(142, 23);
            this.txtTotal.TabIndex = 167;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 146;
            this.label2.Text = " - Nombre";
            // 
            // txtApeCliente
            // 
            this.txtApeCliente._columna = "apellidoCliente";
            this.txtApeCliente._mensajeError = "*";
            this.txtApeCliente._repetible = false;
            this.txtApeCliente._validable = true;
            this.txtApeCliente.Location = new System.Drawing.Point(148, 226);
            this.txtApeCliente.Name = "txtApeCliente";
            this.txtApeCliente.ReadOnly = true;
            this.txtApeCliente.Size = new System.Drawing.Size(142, 23);
            this.txtApeCliente.TabIndex = 166;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 147;
            this.label3.Text = "Cuit Cliente";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente._columna = "nombreCliente";
            this.txtNomCliente._mensajeError = "*";
            this.txtNomCliente._repetible = false;
            this.txtNomCliente._validable = true;
            this.txtNomCliente.Location = new System.Drawing.Point(148, 186);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.ReadOnly = true;
            this.txtNomCliente.Size = new System.Drawing.Size(142, 23);
            this.txtNomCliente.TabIndex = 165;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 148;
            this.label4.Text = " - Apellido";
            // 
            // cmbTipoDocVendedor
            // 
            this.cmbTipoDocVendedor._columna = "tipoDocVendedor";
            this.cmbTipoDocVendedor._MensajeError = "No hay tipo de documento del vendedor.";
            this.cmbTipoDocVendedor._repetible = false;
            this.cmbTipoDocVendedor._Validable = true;
            this.cmbTipoDocVendedor.FormattingEnabled = true;
            this.cmbTipoDocVendedor.Location = new System.Drawing.Point(490, 106);
            this.cmbTipoDocVendedor.Name = "cmbTipoDocVendedor";
            this.cmbTipoDocVendedor.Size = new System.Drawing.Size(142, 23);
            this.cmbTipoDocVendedor.TabIndex = 164;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(333, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 149;
            this.label6.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado._columna = "codEstadoCotizacion";
            this.cmbEstado._MensajeError = "No hay estado.";
            this.cmbEstado._repetible = false;
            this.cmbEstado._Validable = true;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(490, 66);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(142, 23);
            this.cmbEstado.TabIndex = 163;
            this.cmbEstado.SelectionChangeCommitted += new System.EventHandler(this.cmbEstado_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(333, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 150;
            this.label5.Text = "Fecha";
            // 
            // cmbCuitCliente
            // 
            this.cmbCuitCliente._columna = "cuitCliente";
            this.cmbCuitCliente._MensajeError = "No hay Cuit del cliente.";
            this.cmbCuitCliente._repetible = false;
            this.cmbCuitCliente._Validable = true;
            this.cmbCuitCliente.FormattingEnabled = true;
            this.cmbCuitCliente.Location = new System.Drawing.Point(148, 146);
            this.cmbCuitCliente.Name = "cmbCuitCliente";
            this.cmbCuitCliente.Size = new System.Drawing.Size(142, 23);
            this.cmbCuitCliente.TabIndex = 162;
            this.cmbCuitCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCuitCliente_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(333, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 151;
            this.label7.Text = "Tipo Doc Vendedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(333, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 152;
            this.label8.Text = "Doc Vendedor";
            // 
            // txtMotivoPerdida
            // 
            this.txtMotivoPerdida._columna = "motivoPerdida";
            this.txtMotivoPerdida._mensajeError = "No hay motivo de perdida.";
            this.txtMotivoPerdida._repetible = false;
            this.txtMotivoPerdida._validable = false;
            this.txtMotivoPerdida.Location = new System.Drawing.Point(148, 279);
            this.txtMotivoPerdida.MaxLength = 50;
            this.txtMotivoPerdida.Name = "txtMotivoPerdida";
            this.txtMotivoPerdida.Size = new System.Drawing.Size(142, 23);
            this.txtMotivoPerdida.TabIndex = 160;
            this.txtMotivoPerdida.Click += new System.EventHandler(this.txtMotivoPerdida_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(333, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 153;
            this.label9.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones._columna = "observaciones";
            this.txtObservaciones._mensajeError = "No hay observacion cargada.";
            this.txtObservaciones._repetible = false;
            this.txtObservaciones._validable = true;
            this.txtObservaciones.Location = new System.Drawing.Point(490, 226);
            this.txtObservaciones.MaxLength = 50;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(142, 23);
            this.txtObservaciones.TabIndex = 159;
            // 
            // lblMotivoPerdida
            // 
            this.lblMotivoPerdida.AutoSize = true;
            this.lblMotivoPerdida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMotivoPerdida.Location = new System.Drawing.Point(16, 278);
            this.lblMotivoPerdida.Name = "lblMotivoPerdida";
            this.lblMotivoPerdida.Size = new System.Drawing.Size(110, 20);
            this.lblMotivoPerdida.TabIndex = 154;
            this.lblMotivoPerdida.Text = "Motivo Perdida";
            // 
            // txtNumDocVendedor
            // 
            this.txtNumDocVendedor._columna = "numDocVendedor";
            this.txtNumDocVendedor._mensajeError = "No está el documento del vendedor.";
            this.txtNumDocVendedor._repetible = false;
            this.txtNumDocVendedor._validable = true;
            this.txtNumDocVendedor.Location = new System.Drawing.Point(490, 146);
            this.txtNumDocVendedor.MaxLength = 20;
            this.txtNumDocVendedor.Name = "txtNumDocVendedor";
            this.txtNumDocVendedor.Size = new System.Drawing.Size(142, 23);
            this.txtNumDocVendedor.TabIndex = 158;
            // 
            // lblCompetidor
            // 
            this.lblCompetidor.AutoSize = true;
            this.lblCompetidor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompetidor.Location = new System.Drawing.Point(16, 318);
            this.lblCompetidor.Name = "lblCompetidor";
            this.lblCompetidor.Size = new System.Drawing.Size(89, 20);
            this.lblCompetidor.TabIndex = 155;
            this.lblCompetidor.Text = "Competidor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(333, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 157;
            this.label11.Text = "Total:";
            // 
            // txtAño
            // 
            this.txtAño._columna = "año";
            this.txtAño._mensajeError = "No cargó año.";
            this.txtAño._repetible = false;
            this.txtAño._validable = true;
            this.txtAño.Location = new System.Drawing.Point(148, 106);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(142, 23);
            this.txtAño.TabIndex = 156;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(932, 368);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 30);
            this.btnCerrar.TabIndex = 140;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(839, 368);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 30);
            this.btnGuardar.TabIndex = 139;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblModificarEmpleado
            // 
            this.lblModificarEmpleado.AutoSize = true;
            this.lblModificarEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblModificarEmpleado.Location = new System.Drawing.Point(14, 9);
            this.lblModificarEmpleado.Name = "lblModificarEmpleado";
            this.lblModificarEmpleado.Size = new System.Drawing.Size(201, 32);
            this.lblModificarEmpleado.TabIndex = 138;
            this.lblModificarEmpleado.Text = "Nueva Cotizacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Location = new System.Drawing.Point(6, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 318);
            this.groupBox1.TabIndex = 141;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cotizacion";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(378, 229);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 30);
            this.btnCalcular.TabIndex = 138;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.cmbProducto);
            this.groupBox2.Controls.Add(this.btnAgregarDetalleCot);
            this.groupBox2.Controls.Add(this.btnBorrarDetalleCot);
            this.groupBox2.Controls.Add(this.dataGridViewDetalleCot);
            this.groupBox2.Location = new System.Drawing.Point(651, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 350);
            this.groupBox2.TabIndex = 142;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Detalles Cotizacion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(22, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 139;
            this.label12.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(22, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 138;
            this.label10.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad._columna = null;
            this.txtCantidad._mensajeError = "No seleccionó la cantidad";
            this.txtCantidad._repetible = false;
            this.txtCantidad._validable = true;
            this.txtCantidad.Location = new System.Drawing.Point(112, 69);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 113;
            // 
            // cmbProducto
            // 
            this.cmbProducto._columna = "nombre";
            this.cmbProducto._MensajeError = "No seleccionó Producto";
            this.cmbProducto._repetible = false;
            this.cmbProducto._Validable = true;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(112, 32);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 23);
            this.cmbProducto.TabIndex = 112;
            // 
            // btnAgregarDetalleCot
            // 
            this.btnAgregarDetalleCot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalleCot.BackgroundImage")));
            this.btnAgregarDetalleCot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDetalleCot.Location = new System.Drawing.Point(313, 20);
            this.btnAgregarDetalleCot.Name = "btnAgregarDetalleCot";
            this.btnAgregarDetalleCot.Size = new System.Drawing.Size(44, 43);
            this.btnAgregarDetalleCot.TabIndex = 110;
            this.btnAgregarDetalleCot.UseVisualStyleBackColor = true;
            this.btnAgregarDetalleCot.Click += new System.EventHandler(this.btnAgregarDetalleCot_Click);
            // 
            // btnBorrarDetalleCot
            // 
            this.btnBorrarDetalleCot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarDetalleCot.BackgroundImage")));
            this.btnBorrarDetalleCot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarDetalleCot.Location = new System.Drawing.Point(312, 69);
            this.btnBorrarDetalleCot.Name = "btnBorrarDetalleCot";
            this.btnBorrarDetalleCot.Size = new System.Drawing.Size(45, 43);
            this.btnBorrarDetalleCot.TabIndex = 111;
            this.btnBorrarDetalleCot.UseVisualStyleBackColor = true;
            this.btnBorrarDetalleCot.Click += new System.EventHandler(this.btnBorrarDetalleCot_Click);
            // 
            // dataGridViewDetalleCot
            // 
            this.dataGridViewDetalleCot.AllowUserToAddRows = false;
            this.dataGridViewDetalleCot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetalleCot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleCot.Location = new System.Drawing.Point(12, 118);
            this.dataGridViewDetalleCot.Name = "dataGridViewDetalleCot";
            this.dataGridViewDetalleCot.RowHeadersVisible = false;
            this.dataGridViewDetalleCot.RowTemplate.Height = 25;
            this.dataGridViewDetalleCot.Size = new System.Drawing.Size(345, 219);
            this.dataGridViewDetalleCot.TabIndex = 109;
            // 
            // Frm_AltaCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 406);
            this.Controls.Add(this.txtNomCompetidor);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoDocVendedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCuitCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMotivoPerdida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblMotivoPerdida);
            this.Controls.Add(this.txtNumDocVendedor);
            this.Controls.Add(this.lblCompetidor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblModificarEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(1040, 445);
            this.Name = "Frm_AltaCotizacion";
            this.Text = "Frm_AltaCotizacion";
            this.Load += new System.EventHandler(this.Frm_AltaCotizacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleCot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txtNomCompetidor;
        private Clases.DateTimePicker01 dtpFecha;
        private Clases.TextBox01 txtNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txtTotal;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txtApeCliente;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txtNomCliente;
        private System.Windows.Forms.Label label4;
        private Clases.ComboBox01 cmbTipoDocVendedor;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 cmbEstado;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBox01 cmbCuitCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Clases.TextBox01 txtMotivoPerdida;
        private System.Windows.Forms.Label label9;
        private Clases.TextBox01 txtObservaciones;
        private System.Windows.Forms.Label lblMotivoPerdida;
        private Clases.TextBox01 txtNumDocVendedor;
        private System.Windows.Forms.Label lblCompetidor;
        private System.Windows.Forms.Label label11;
        private Clases.TextBox01 txtAño;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblModificarEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Clases.TextBox01 txtCantidad;
        private Clases.ComboBox01 cmbProducto;
        private System.Windows.Forms.Button btnAgregarDetalleCot;
        private System.Windows.Forms.Button btnBorrarDetalleCot;
        private Clases.Grid01 dataGridViewDetalleCot;
    }
}