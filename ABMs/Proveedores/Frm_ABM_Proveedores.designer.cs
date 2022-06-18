
namespace TuLuzNet.ABMs
{
    partial class Frm_ABM_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Proveedores));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grBoxFiltros = new System.Windows.Forms.GroupBox();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.chkBoxActivo = new System.Windows.Forms.CheckBox();
            this.chkBoxTodos = new System.Windows.Forms.CheckBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewProveedores = new TuLuzNet.Clases.Grid01();
            this.grBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(497, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(113, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(62, 445);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 43);
            this.btnEditar.TabIndex = 13;
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
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grBoxFiltros
            // 
            this.grBoxFiltros.Controls.Add(this.dataGridViewProveedores);
            this.grBoxFiltros.Controls.Add(this.lblProveedores);
            this.grBoxFiltros.Controls.Add(this.chkBoxActivo);
            this.grBoxFiltros.Controls.Add(this.chkBoxTodos);
            this.grBoxFiltros.Controls.Add(this.lblRazonSocial);
            this.grBoxFiltros.Controls.Add(this.txtBoxRazonSocial);
            this.grBoxFiltros.Controls.Add(this.btnBuscar);
            this.grBoxFiltros.Location = new System.Drawing.Point(12, 12);
            this.grBoxFiltros.Name = "grBoxFiltros";
            this.grBoxFiltros.Size = new System.Drawing.Size(536, 427);
            this.grBoxFiltros.TabIndex = 12;
            this.grBoxFiltros.TabStop = false;
            this.grBoxFiltros.Text = "Filtros";
            this.grBoxFiltros.Enter += new System.EventHandler(this.grBoxFiltros_Enter);
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblProveedores.Location = new System.Drawing.Point(13, 18);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(204, 32);
            this.lblProveedores.TabIndex = 9;
            this.lblProveedores.Text = "ABM Proveedores";
            // 
            // chkBoxActivo
            // 
            this.chkBoxActivo.AutoSize = true;
            this.chkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxActivo.Location = new System.Drawing.Point(117, 124);
            this.chkBoxActivo.Name = "chkBoxActivo";
            this.chkBoxActivo.Size = new System.Drawing.Size(70, 24);
            this.chkBoxActivo.TabIndex = 8;
            this.chkBoxActivo.Text = "Activo";
            this.chkBoxActivo.UseVisualStyleBackColor = true;
            this.chkBoxActivo.CheckedChanged += new System.EventHandler(this.chkBoxActivo_CheckedChanged);
            // 
            // chkBoxTodos
            // 
            this.chkBoxTodos.AutoSize = true;
            this.chkBoxTodos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxTodos.Location = new System.Drawing.Point(117, 94);
            this.chkBoxTodos.Name = "chkBoxTodos";
            this.chkBoxTodos.Size = new System.Drawing.Size(68, 24);
            this.chkBoxTodos.TabIndex = 7;
            this.chkBoxTodos.Text = "Todos";
            this.chkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRazonSocial.Location = new System.Drawing.Point(17, 66);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(94, 20);
            this.lblRazonSocial.TabIndex = 6;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(117, 65);
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(189, 23);
            this.txtBoxRazonSocial.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(420, 170);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 26);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewProveedores
            // 
            this.dataGridViewProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedores.Location = new System.Drawing.Point(13, 202);
            this.dataGridViewProveedores.Name = "dataGridViewProveedores";
            this.dataGridViewProveedores.RowTemplate.Height = 25;
            this.dataGridViewProveedores.Size = new System.Drawing.Size(511, 219);
            this.dataGridViewProveedores.TabIndex = 10;
            // 
            // Frm_ABM_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grBoxFiltros);
            this.Name = "Frm_ABM_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Proveedores";
            this.Load += new System.EventHandler(this.Frm_ABM_Proveedores_Load);
            this.grBoxFiltros.ResumeLayout(false);
            this.grBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grBoxFiltros;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.CheckBox chkBoxActivo;
        private System.Windows.Forms.CheckBox chkBoxTodos;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtBoxRazonSocial;
        private System.Windows.Forms.Button btnBuscar;
        private Clases.Grid01 dataGridViewProveedores;
    }
}