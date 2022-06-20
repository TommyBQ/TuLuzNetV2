
namespace TuLuzNet.Procedimientos.Factura
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new TuLuzNet.Clases.TextBox01();
            this.cmbProducto = new TuLuzNet.Clases.ComboBox01();
            this.btnBorrarDetalleFac = new System.Windows.Forms.Button();
            this.btnAgregarDetalleFac = new System.Windows.Forms.Button();
            this.dataGridViewDetalleFac = new TuLuzNet.Clases.Grid01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new TuLuzNet.Clases.DateTimePicker01();
            this.cmb_docEmpleados = new TuLuzNet.Clases.ComboBox01();
            this.txtCuilCuit = new TuLuzNet.Clases.TextBox01();
            this.txtNumFactura = new TuLuzNet.Clases.TextBox01();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTipoFactura = new TuLuzNet.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAgregarBarrio = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFac)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(793, 477);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCargar.Location = new System.Drawing.Point(687, 477);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 34);
            this.btnCargar.TabIndex = 47;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarTodos);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.cmbProducto);
            this.groupBox2.Controls.Add(this.btnBorrarDetalleFac);
            this.groupBox2.Controls.Add(this.btnAgregarDetalleFac);
            this.groupBox2.Controls.Add(this.dataGridViewDetalleFac);
            this.groupBox2.Location = new System.Drawing.Point(460, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(433, 416);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Detalles Factura";
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscarTodos.Location = new System.Drawing.Point(281, 82);
            this.btnBuscarTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(144, 33);
            this.btnBuscarTodos.TabIndex = 42;
            this.btnBuscarTodos.Text = "Buscar Todos";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label12.Location = new System.Drawing.Point(8, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 25);
            this.label12.TabIndex = 143;
            this.label12.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label10.Location = new System.Drawing.Point(8, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 142;
            this.label10.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad._columna = null;
            this.txtCantidad._mensajeError = "No seleccionó la cantidad";
            this.txtCantidad._repetible = false;
            this.txtCantidad._validable = true;
            this.txtCantidad.Location = new System.Drawing.Point(111, 66);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(137, 22);
            this.txtCantidad.TabIndex = 141;
            // 
            // cmbProducto
            // 
            this.cmbProducto._columna = "nombre";
            this.cmbProducto._MensajeError = "No seleccionó Producto";
            this.cmbProducto._repetible = false;
            this.cmbProducto._Validable = true;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(111, 26);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(137, 24);
            this.cmbProducto.TabIndex = 140;
            // 
            // btnBorrarDetalleFac
            // 
            this.btnBorrarDetalleFac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarDetalleFac.BackgroundImage")));
            this.btnBorrarDetalleFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarDetalleFac.Location = new System.Drawing.Point(373, 14);
            this.btnBorrarDetalleFac.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarDetalleFac.Name = "btnBorrarDetalleFac";
            this.btnBorrarDetalleFac.Size = new System.Drawing.Size(52, 46);
            this.btnBorrarDetalleFac.TabIndex = 41;
            this.btnBorrarDetalleFac.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDetalleFac
            // 
            this.btnAgregarDetalleFac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalleFac.BackgroundImage")));
            this.btnAgregarDetalleFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDetalleFac.Location = new System.Drawing.Point(306, 14);
            this.btnAgregarDetalleFac.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDetalleFac.Name = "btnAgregarDetalleFac";
            this.btnAgregarDetalleFac.Size = new System.Drawing.Size(51, 46);
            this.btnAgregarDetalleFac.TabIndex = 40;
            this.btnAgregarDetalleFac.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDetalleFac
            // 
            this.dataGridViewDetalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleFac.Location = new System.Drawing.Point(8, 126);
            this.dataGridViewDetalleFac.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDetalleFac.Name = "dataGridViewDetalleFac";
            this.dataGridViewDetalleFac.RowHeadersWidth = 51;
            this.dataGridViewDetalleFac.RowTemplate.Height = 25;
            this.dataGridViewDetalleFac.Size = new System.Drawing.Size(422, 281);
            this.dataGridViewDetalleFac.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.cmb_docEmpleados);
            this.groupBox1.Controls.Add(this.txtCuilCuit);
            this.groupBox1.Controls.Add(this.txtNumFactura);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtTipoFactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(433, 416);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Factura";
            // 
            // dtpFecha
            // 
            this.dtpFecha._columna = "fecha";
            this.dtpFecha._mensajeError = "Error fecha";
            this.dtpFecha._repetible = true;
            this.dtpFecha._validable = true;
            this.dtpFecha.CustomFormat = "dd MMMM yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(165, 85);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(259, 22);
            this.dtpFecha.TabIndex = 169;
            // 
            // cmb_docEmpleados
            // 
            this.cmb_docEmpleados._columna = "numDoc";
            this.cmb_docEmpleados._MensajeError = "No selecciono el documento de un empleado";
            this.cmb_docEmpleados._repetible = false;
            this.cmb_docEmpleados._Validable = true;
            this.cmb_docEmpleados.FormattingEnabled = true;
            this.cmb_docEmpleados.Location = new System.Drawing.Point(249, 167);
            this.cmb_docEmpleados.Name = "cmb_docEmpleados";
            this.cmb_docEmpleados.Size = new System.Drawing.Size(175, 24);
            this.cmb_docEmpleados.TabIndex = 41;
            // 
            // txtCuilCuit
            // 
            this.txtCuilCuit._columna = "cuilCuit";
            this.txtCuilCuit._mensajeError = "No cargó CUIL/CUIT";
            this.txtCuilCuit._repetible = true;
            this.txtCuilCuit._validable = true;
            this.txtCuilCuit.Location = new System.Drawing.Point(165, 208);
            this.txtCuilCuit.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuilCuit.Name = "txtCuilCuit";
            this.txtCuilCuit.Size = new System.Drawing.Size(259, 22);
            this.txtCuilCuit.TabIndex = 39;
            // 
            // txtNumFactura
            // 
            this.txtNumFactura._columna = "numeroFactura";
            this.txtNumFactura._mensajeError = "No cargó N° Factura.";
            this.txtNumFactura._repetible = false;
            this.txtNumFactura._validable = true;
            this.txtNumFactura.Location = new System.Drawing.Point(165, 44);
            this.txtNumFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(259, 22);
            this.txtNumFactura.TabIndex = 31;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombre.Location = new System.Drawing.Point(16, 39);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 25);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "N° Factura";
            // 
            // txtTipoFactura
            // 
            this.txtTipoFactura._columna = "tipoFactura";
            this.txtTipoFactura._mensajeError = "No cargó tipo Factura.";
            this.txtTipoFactura._repetible = true;
            this.txtTipoFactura._validable = true;
            this.txtTipoFactura.Location = new System.Drawing.Point(165, 127);
            this.txtTipoFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoFactura.Name = "txtTipoFactura";
            this.txtTipoFactura.Size = new System.Drawing.Size(259, 22);
            this.txtTipoFactura.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(16, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "CUIL/CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(16, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "N° Documento Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tipo Factura";
            // 
            // lblAgregarBarrio
            // 
            this.lblAgregarBarrio.AutoSize = true;
            this.lblAgregarBarrio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline);
            this.lblAgregarBarrio.Location = new System.Drawing.Point(5, 16);
            this.lblAgregarBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarBarrio.Name = "lblAgregarBarrio";
            this.lblAgregarBarrio.Size = new System.Drawing.Size(208, 41);
            this.lblAgregarBarrio.TabIndex = 44;
            this.lblAgregarBarrio.Text = "Cargar Factura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 526);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAgregarBarrio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFac)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Clases.TextBox01 txtCantidad;
        private Clases.ComboBox01 cmbProducto;
        private System.Windows.Forms.Button btnBorrarDetalleFac;
        private System.Windows.Forms.Button btnAgregarDetalleFac;
        private Clases.Grid01 dataGridViewDetalleFac;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.DateTimePicker01 dtpFecha;
        private Clases.ComboBox01 cmb_docEmpleados;
        private Clases.TextBox01 txtCuilCuit;
        private Clases.TextBox01 txtNumFactura;
        private System.Windows.Forms.Label lblNombre;
        private Clases.TextBox01 txtTipoFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAgregarBarrio;
    }
}