
namespace TuLuzNet.ABMs
{
    partial class Frm_ABM_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Empleados));
            this.button2 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grBoxFiltros = new System.Windows.Forms.GroupBox();
            this.cmbTipoDocumento = new TuLuzNet.Clases.ComboBox01();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.chkBoxTodos = new System.Windows.Forms.CheckBox();
            this.txtBoxNumDoc = new System.Windows.Forms.TextBox();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.grBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(655, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrar.Location = new System.Drawing.Point(113, 445);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 43);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(62, 445);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 43);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Location = new System.Drawing.Point(12, 445);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 43);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grBoxFiltros
            // 
            this.grBoxFiltros.Controls.Add(this.cmbTipoDocumento);
            this.grBoxFiltros.Controls.Add(this.lblTipoDoc);
            this.grBoxFiltros.Controls.Add(this.lblNombre);
            this.grBoxFiltros.Controls.Add(this.txtBoxNombre);
            this.grBoxFiltros.Controls.Add(this.lblNumDoc);
            this.grBoxFiltros.Controls.Add(this.chkBoxTodos);
            this.grBoxFiltros.Controls.Add(this.txtBoxNumDoc);
            this.grBoxFiltros.Controls.Add(this.lblEmpleados);
            this.grBoxFiltros.Controls.Add(this.lblApellido);
            this.grBoxFiltros.Controls.Add(this.txtBoxApellido);
            this.grBoxFiltros.Controls.Add(this.btnBuscar);
            this.grBoxFiltros.Controls.Add(this.dataGridViewEmpleados);
            this.grBoxFiltros.Location = new System.Drawing.Point(12, 12);
            this.grBoxFiltros.Name = "grBoxFiltros";
            this.grBoxFiltros.Size = new System.Drawing.Size(688, 427);
            this.grBoxFiltros.TabIndex = 7;
            this.grBoxFiltros.TabStop = false;
            this.grBoxFiltros.Text = "Filtros";
            this.grBoxFiltros.Enter += new System.EventHandler(this.grBoxFiltros_Enter);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento._columna = "nombre";
            this.cmbTipoDocumento._MensajeError = "No hay tipo de documento.";
            this.cmbTipoDocumento._repetible = false;
            this.cmbTipoDocumento._Validable = false;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.ItemHeight = 15;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(433, 91);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(146, 23);
            this.cmbTipoDocumento.TabIndex = 15;
            this.cmbTipoDocumento.SelectedValueChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedValueChanged);
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDoc.Location = new System.Drawing.Point(282, 95);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(142, 20);
            this.lblTipoDoc.TabIndex = 14;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(17, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(87, 92);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(189, 23);
            this.txtBoxNombre.TabIndex = 2;
            this.txtBoxNombre.Click += new System.EventHandler(this.txtBoxNombre_Click);
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumDoc.Location = new System.Drawing.Point(282, 64);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(145, 20);
            this.lblNumDoc.TabIndex = 11;
            this.lblNumDoc.Text = "Número Documento";
            // 
            // chkBoxTodos
            // 
            this.chkBoxTodos.AutoSize = true;
            this.chkBoxTodos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxTodos.Location = new System.Drawing.Point(87, 121);
            this.chkBoxTodos.Name = "chkBoxTodos";
            this.chkBoxTodos.Size = new System.Drawing.Size(68, 24);
            this.chkBoxTodos.TabIndex = 5;
            this.chkBoxTodos.Text = "Todos";
            this.chkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // txtBoxNumDoc
            // 
            this.txtBoxNumDoc.Location = new System.Drawing.Point(433, 61);
            this.txtBoxNumDoc.Name = "txtBoxNumDoc";
            this.txtBoxNumDoc.Size = new System.Drawing.Size(146, 23);
            this.txtBoxNumDoc.TabIndex = 3;
            this.txtBoxNumDoc.Click += new System.EventHandler(this.txtBoxNumDoc_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleados.Location = new System.Drawing.Point(13, 18);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(188, 32);
            this.lblEmpleados.TabIndex = 9;
            this.lblEmpleados.Text = "ABM Empleados";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(17, 66);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(87, 62);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(189, 23);
            this.txtBoxApellido.TabIndex = 1;
            this.txtBoxApellido.Click += new System.EventHandler(this.txtBoxApellido_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(585, 167);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 26);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(6, 202);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.RowTemplate.Height = 25;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(676, 219);
            this.dataGridViewEmpleados.TabIndex = 0;
            // 
            // Frm_ABM_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grBoxFiltros);
            this.Name = "Frm_ABM_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Empleados";
            this.Load += new System.EventHandler(this.Frm_ABM_Empleados_Load);
            this.grBoxFiltros.ResumeLayout(false);
            this.grBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grBoxFiltros;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.CheckBox chkBoxTodos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.TextBox txtBoxNumDoc;
        private Clases.ComboBox01 cmbTipoDocumento;
    }
}