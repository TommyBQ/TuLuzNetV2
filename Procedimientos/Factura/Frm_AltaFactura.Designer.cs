
namespace TuLuzNet.Procedimientos.Factura
{
    partial class Frm_AltaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AltaFactura));
            this.lblAgregarBarrio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dtpFecha = new TuLuzNet.Clases.DateTimePicker01();
            this.txtCuilCuit = new TuLuzNet.Clases.TextBox01();
            this.txtNumFactura = new TuLuzNet.Clases.TextBox01();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTipoFactura = new TuLuzNet.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_Activo = new TuLuzNet.Clases.CheckBox01();
            this.cmb_docEmpleados = new TuLuzNet.Clases.ComboBox01();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new TuLuzNet.Clases.TextBox01();
            this.cmbProducto = new TuLuzNet.Clases.ComboBox01();
            this.btnAgregarDetalleCot = new System.Windows.Forms.Button();
            this.btnBorrarDetalleCot = new System.Windows.Forms.Button();
            this.dataGridViewDetalleFac = new TuLuzNet.Clases.Grid01();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new TuLuzNet.Clases.TextBox01();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumDetalleFactura = new TuLuzNet.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFac)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarBarrio
            // 
            this.lblAgregarBarrio.AutoSize = true;
            this.lblAgregarBarrio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline);
            this.lblAgregarBarrio.Location = new System.Drawing.Point(12, 9);
            this.lblAgregarBarrio.Name = "lblAgregarBarrio";
            this.lblAgregarBarrio.Size = new System.Drawing.Size(167, 32);
            this.lblAgregarBarrio.TabIndex = 11;
            this.lblAgregarBarrio.Text = "Nueva Factura";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(623, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCargar.Location = new System.Drawing.Point(542, 306);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 28);
            this.btnCargar.TabIndex = 42;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha._columna = "fecha";
            this.dtpFecha._mensajeError = "Error fecha";
            this.dtpFecha._repetible = true;
            this.dtpFecha._validable = true;
            this.dtpFecha.CustomFormat = "dd MMMM yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(123, 101);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(195, 20);
            this.dtpFecha.TabIndex = 179;
            // 
            // txtCuilCuit
            // 
            this.txtCuilCuit._columna = "cuilCuit";
            this.txtCuilCuit._mensajeError = "No cargó CUIL/CUIT";
            this.txtCuilCuit._repetible = true;
            this.txtCuilCuit._validable = true;
            this.txtCuilCuit.Location = new System.Drawing.Point(123, 201);
            this.txtCuilCuit.Name = "txtCuilCuit";
            this.txtCuilCuit.Size = new System.Drawing.Size(195, 20);
            this.txtCuilCuit.TabIndex = 177;
            // 
            // txtNumFactura
            // 
            this.txtNumFactura._columna = "numeroFactura";
            this.txtNumFactura._mensajeError = "No cargó N° Factura.";
            this.txtNumFactura._repetible = false;
            this.txtNumFactura._validable = false;
            this.txtNumFactura.Location = new System.Drawing.Point(123, 67);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(195, 20);
            this.txtNumFactura.TabIndex = 171;
            this.txtNumFactura.TextChanged += new System.EventHandler(this.txtNumFactura_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombre.Location = new System.Drawing.Point(11, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 20);
            this.lblNombre.TabIndex = 170;
            this.lblNombre.Text = "N° Factura";
            // 
            // txtTipoFactura
            // 
            this.txtTipoFactura._columna = "tipoFactura";
            this.txtTipoFactura._mensajeError = "No cargó tipo Factura.";
            this.txtTipoFactura._repetible = true;
            this.txtTipoFactura._validable = true;
            this.txtTipoFactura.Location = new System.Drawing.Point(123, 135);
            this.txtTipoFactura.Name = "txtTipoFactura";
            this.txtTipoFactura.Size = new System.Drawing.Size(195, 20);
            this.txtTipoFactura.TabIndex = 176;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(11, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 172;
            this.label1.Text = "CUIL/CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(11, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 173;
            this.label2.Text = "N° Documento Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 175;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(11, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 174;
            this.label3.Text = "Tipo Factura";
            // 
            // chk_Activo
            // 
            this.chk_Activo._columna = "activo";
            this.chk_Activo._mensajeError = "No selecciono Estado";
            this.chk_Activo._validable = true;
            this.chk_Activo.AutoSize = true;
            this.chk_Activo.Location = new System.Drawing.Point(15, 248);
            this.chk_Activo.Margin = new System.Windows.Forms.Padding(2);
            this.chk_Activo.Name = "chk_Activo";
            this.chk_Activo.Size = new System.Drawing.Size(56, 17);
            this.chk_Activo.TabIndex = 180;
            this.chk_Activo.Text = "Activo";
            this.chk_Activo.UseVisualStyleBackColor = true;
            // 
            // cmb_docEmpleados
            // 
            this.cmb_docEmpleados._columna = "numDocEmpleado";
            this.cmb_docEmpleados._MensajeError = "No selecciono un dni empleado";
            this.cmb_docEmpleados._repetible = false;
            this.cmb_docEmpleados._Validable = true;
            this.cmb_docEmpleados.FormattingEnabled = true;
            this.cmb_docEmpleados.Location = new System.Drawing.Point(197, 167);
            this.cmb_docEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_docEmpleados.Name = "cmb_docEmpleados";
            this.cmb_docEmpleados.Size = new System.Drawing.Size(121, 21);
            this.cmb_docEmpleados.TabIndex = 181;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label12.Location = new System.Drawing.Point(448, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 188;
            this.label12.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label10.Location = new System.Drawing.Point(456, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 187;
            this.label10.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad._columna = null;
            this.txtCantidad._mensajeError = "No seleccionó la cantidad";
            this.txtCantidad._repetible = false;
            this.txtCantidad._validable = true;
            this.txtCantidad.Location = new System.Drawing.Point(537, 50);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(104, 20);
            this.txtCantidad.TabIndex = 186;
            // 
            // cmbProducto
            // 
            this.cmbProducto._columna = "nombre";
            this.cmbProducto._MensajeError = "No seleccionó Producto";
            this.cmbProducto._repetible = false;
            this.cmbProducto._Validable = true;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(537, 19);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(104, 21);
            this.cmbProducto.TabIndex = 185;
            // 
            // btnAgregarDetalleCot
            // 
            this.btnAgregarDetalleCot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalleCot.BackgroundImage")));
            this.btnAgregarDetalleCot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDetalleCot.Location = new System.Drawing.Point(660, 19);
            this.btnAgregarDetalleCot.Name = "btnAgregarDetalleCot";
            this.btnAgregarDetalleCot.Size = new System.Drawing.Size(38, 37);
            this.btnAgregarDetalleCot.TabIndex = 183;
            this.btnAgregarDetalleCot.UseVisualStyleBackColor = true;
            this.btnAgregarDetalleCot.Click += new System.EventHandler(this.btnAgregarDetalleCot_Click);
            // 
            // btnBorrarDetalleCot
            // 
            this.btnBorrarDetalleCot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarDetalleCot.BackgroundImage")));
            this.btnBorrarDetalleCot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarDetalleCot.Location = new System.Drawing.Point(659, 63);
            this.btnBorrarDetalleCot.Name = "btnBorrarDetalleCot";
            this.btnBorrarDetalleCot.Size = new System.Drawing.Size(39, 37);
            this.btnBorrarDetalleCot.TabIndex = 184;
            this.btnBorrarDetalleCot.UseVisualStyleBackColor = true;
            this.btnBorrarDetalleCot.Click += new System.EventHandler(this.btnBorrarDetalleCot_Click);
            // 
            // dataGridViewDetalleFac
            // 
            this.dataGridViewDetalleFac.AllowUserToAddRows = false;
            this.dataGridViewDetalleFac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleFac.Location = new System.Drawing.Point(404, 110);
            this.dataGridViewDetalleFac.Name = "dataGridViewDetalleFac";
            this.dataGridViewDetalleFac.RowHeadersVisible = false;
            this.dataGridViewDetalleFac.RowHeadersWidth = 51;
            this.dataGridViewDetalleFac.RowTemplate.Height = 25;
            this.dataGridViewDetalleFac.Size = new System.Drawing.Size(296, 190);
            this.dataGridViewDetalleFac.TabIndex = 182;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCalcular.Location = new System.Drawing.Point(15, 302);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 26);
            this.btnCalcular.TabIndex = 189;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal
            // 
            this.txtTotal._columna = "precioTotal";
            this.txtTotal._mensajeError = "Total calculable MAL ERROR";
            this.txtTotal._repetible = false;
            this.txtTotal._validable = true;
            this.txtTotal.Location = new System.Drawing.Point(189, 305);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(122, 20);
            this.txtTotal.TabIndex = 191;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label11.Location = new System.Drawing.Point(119, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 190;
            this.label11.Text = "Total:";
            // 
            // txtNumDetalleFactura
            // 
            this.txtNumDetalleFactura._columna = "numeroDetalleFactura";
            this.txtNumDetalleFactura._mensajeError = "No ingreso el numero de detalle de factura";
            this.txtNumDetalleFactura._repetible = false;
            this.txtNumDetalleFactura._validable = true;
            this.txtNumDetalleFactura.Location = new System.Drawing.Point(537, 82);
            this.txtNumDetalleFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumDetalleFactura.Name = "txtNumDetalleFactura";
            this.txtNumDetalleFactura.Size = new System.Drawing.Size(104, 20);
            this.txtNumDetalleFactura.TabIndex = 192;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(364, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 193;
            this.label5.Text = "Numero Detalle Factura";
            // 
            // Frm_AltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumDetalleFactura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.btnAgregarDetalleCot);
            this.Controls.Add(this.btnBorrarDetalleCot);
            this.Controls.Add(this.dataGridViewDetalleFac);
            this.Controls.Add(this.cmb_docEmpleados);
            this.Controls.Add(this.chk_Activo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtCuilCuit);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtTipoFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblAgregarBarrio);
            this.Name = "Frm_AltaFactura";
            this.Text = "Cargar Factura";
            this.Load += new System.EventHandler(this.Frm_AltaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarBarrio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargar;
        private Clases.DateTimePicker01 dtpFecha;
        private Clases.TextBox01 txtCuilCuit;
        private Clases.TextBox01 txtNumFactura;
        private System.Windows.Forms.Label lblNombre;
        private Clases.TextBox01 txtTipoFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Clases.CheckBox01 chk_Activo;
        private Clases.ComboBox01 cmb_docEmpleados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Clases.TextBox01 txtCantidad;
        private Clases.ComboBox01 cmbProducto;
        private System.Windows.Forms.Button btnAgregarDetalleCot;
        private System.Windows.Forms.Button btnBorrarDetalleCot;
        private Clases.Grid01 dataGridViewDetalleFac;
        private System.Windows.Forms.Button btnCalcular;
        private Clases.TextBox01 txtTotal;
        private System.Windows.Forms.Label label11;
        private Clases.TextBox01 txtNumDetalleFactura;
        private System.Windows.Forms.Label label5;
    }
}