
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNumFactura = new TuLuzNet.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoFactura = new TuLuzNet.Clases.TextBox01();
            this.txtNumDocEmpleado = new TuLuzNet.Clases.TextBox01();
            this.txtCuilCuit = new TuLuzNet.Clases.TextBox01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.btnAgregarDetalleFac = new System.Windows.Forms.Button();
            this.dataGridViewDetalleFac = new TuLuzNet.Clases.Grid01();
            this.btnBorrarDetalleFac = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFac)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarBarrio
            // 
            this.lblAgregarBarrio.AutoSize = true;
            this.lblAgregarBarrio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline);
            this.lblAgregarBarrio.Location = new System.Drawing.Point(10, 8);
            this.lblAgregarBarrio.Name = "lblAgregarBarrio";
            this.lblAgregarBarrio.Size = new System.Drawing.Size(167, 32);
            this.lblAgregarBarrio.TabIndex = 11;
            this.lblAgregarBarrio.Text = "Cargar Factura";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombre.Location = new System.Drawing.Point(12, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 20);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "N° Factura";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura._columna = "numeroFactura";
            this.txtNumFactura._mensajeError = "No cargó N° Factura.";
            this.txtNumFactura._repetible = false;
            this.txtNumFactura._validable = true;
            this.txtNumFactura.Location = new System.Drawing.Point(124, 36);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(195, 20);
            this.txtNumFactura.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "CUIL/CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "N° Documento Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tipo Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fecha";
            // 
            // txtTipoFactura
            // 
            this.txtTipoFactura._columna = "tipoFactura";
            this.txtTipoFactura._mensajeError = "No cargó tipo Factura.";
            this.txtTipoFactura._repetible = true;
            this.txtTipoFactura._validable = true;
            this.txtTipoFactura.Location = new System.Drawing.Point(124, 103);
            this.txtTipoFactura.Name = "txtTipoFactura";
            this.txtTipoFactura.Size = new System.Drawing.Size(195, 20);
            this.txtTipoFactura.TabIndex = 37;
            // 
            // txtNumDocEmpleado
            // 
            this.txtNumDocEmpleado._columna = "numDocEmpleado";
            this.txtNumDocEmpleado._mensajeError = "No cargó Numero de Docmento de empleado.";
            this.txtNumDocEmpleado._repetible = true;
            this.txtNumDocEmpleado._validable = true;
            this.txtNumDocEmpleado.Location = new System.Drawing.Point(187, 136);
            this.txtNumDocEmpleado.Name = "txtNumDocEmpleado";
            this.txtNumDocEmpleado.Size = new System.Drawing.Size(133, 20);
            this.txtNumDocEmpleado.TabIndex = 38;
            // 
            // txtCuilCuit
            // 
            this.txtCuilCuit._columna = "cuilCuit";
            this.txtCuilCuit._mensajeError = "No cargó CUIL/CUIT";
            this.txtCuilCuit._repetible = true;
            this.txtCuilCuit._validable = true;
            this.txtCuilCuit.Location = new System.Drawing.Point(124, 169);
            this.txtCuilCuit.Name = "txtCuilCuit";
            this.txtCuilCuit.Size = new System.Drawing.Size(195, 20);
            this.txtCuilCuit.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.txtCuilCuit);
            this.groupBox1.Controls.Add(this.txtNumFactura);
            this.groupBox1.Controls.Add(this.txtNumDocEmpleado);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtTipoFactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 338);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Factura";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(124, 67);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(195, 20);
            this.dateTimePickerFecha.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarTodos);
            this.groupBox2.Controls.Add(this.btnAgregarDetalleFac);
            this.groupBox2.Controls.Add(this.dataGridViewDetalleFac);
            this.groupBox2.Controls.Add(this.btnBorrarDetalleFac);
            this.groupBox2.Location = new System.Drawing.Point(351, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 338);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Detalles Factura";
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscarTodos.Location = new System.Drawing.Point(212, 12);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(108, 27);
            this.btnBuscarTodos.TabIndex = 42;
            this.btnBuscarTodos.Text = "Buscar Todos";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // btnAgregarDetalleFac
            // 
            this.btnAgregarDetalleFac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalleFac.BackgroundImage")));
            this.btnAgregarDetalleFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDetalleFac.Location = new System.Drawing.Point(4, 295);
            this.btnAgregarDetalleFac.Name = "btnAgregarDetalleFac";
            this.btnAgregarDetalleFac.Size = new System.Drawing.Size(38, 37);
            this.btnAgregarDetalleFac.TabIndex = 40;
            this.btnAgregarDetalleFac.UseVisualStyleBackColor = true;
            this.btnAgregarDetalleFac.Click += new System.EventHandler(this.btnAgregarDetalleFac_Click);
            // 
            // dataGridViewDetalleFac
            // 
            this.dataGridViewDetalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleFac.Location = new System.Drawing.Point(5, 43);
            this.dataGridViewDetalleFac.Name = "dataGridViewDetalleFac";
            this.dataGridViewDetalleFac.RowTemplate.Height = 25;
            this.dataGridViewDetalleFac.Size = new System.Drawing.Size(315, 247);
            this.dataGridViewDetalleFac.TabIndex = 0;
            this.dataGridViewDetalleFac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid011_CellContentClick);
            // 
            // btnBorrarDetalleFac
            // 
            this.btnBorrarDetalleFac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarDetalleFac.BackgroundImage")));
            this.btnBorrarDetalleFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarDetalleFac.Location = new System.Drawing.Point(47, 296);
            this.btnBorrarDetalleFac.Name = "btnBorrarDetalleFac";
            this.btnBorrarDetalleFac.Size = new System.Drawing.Size(39, 37);
            this.btnBorrarDetalleFac.TabIndex = 41;
            this.btnBorrarDetalleFac.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(601, 383);
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
            this.btnCargar.Location = new System.Drawing.Point(521, 383);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 28);
            this.btnCargar.TabIndex = 42;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Frm_AltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 416);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAgregarBarrio);
            this.Name = "Frm_AltaFactura";
            this.Text = "Cargar Factura";
            this.Load += new System.EventHandler(this.Frm_AltaFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarBarrio;
        private System.Windows.Forms.Label lblNombre;
        private Clases.TextBox01 txtNumFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txtTipoFactura;
        private Clases.TextBox01 txtNumDocEmpleado;
        private Clases.TextBox01 txtCuilCuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Clases.Grid01 dataGridViewDetalleFac;
        private System.Windows.Forms.Button btnAgregarDetalleFac;
        private System.Windows.Forms.Button btnBorrarDetalleFac;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button btnBuscarTodos;
    }
}