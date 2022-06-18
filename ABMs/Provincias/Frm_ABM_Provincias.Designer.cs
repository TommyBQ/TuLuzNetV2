
namespace TuLuzNet.ABMs
{
    partial class Frm_ABM_Provincias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Provincias));
            this.grBoxFiltros = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.chkBoxTodos = new System.Windows.Forms.CheckBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewProvincias = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvincias)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxFiltros
            // 
            this.grBoxFiltros.Controls.Add(this.lblNombre);
            this.grBoxFiltros.Controls.Add(this.txtBoxNombre);
            this.grBoxFiltros.Controls.Add(this.chkBoxTodos);
            this.grBoxFiltros.Controls.Add(this.lblProvincia);
            this.grBoxFiltros.Controls.Add(this.btnBuscar);
            this.grBoxFiltros.Controls.Add(this.dataGridViewProvincias);
            this.grBoxFiltros.Location = new System.Drawing.Point(14, 16);
            this.grBoxFiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxFiltros.Name = "grBoxFiltros";
            this.grBoxFiltros.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxFiltros.Size = new System.Drawing.Size(689, 544);
            this.grBoxFiltros.TabIndex = 27;
            this.grBoxFiltros.TabStop = false;
            this.grBoxFiltros.Text = "Filtros";
            this.grBoxFiltros.Enter += new System.EventHandler(this.grBoxFiltros_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(19, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(99, 93);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(215, 27);
            this.txtBoxNombre.TabIndex = 12;
            // 
            // chkBoxTodos
            // 
            this.chkBoxTodos.AutoSize = true;
            this.chkBoxTodos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxTodos.Location = new System.Drawing.Point(99, 132);
            this.chkBoxTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBoxTodos.Name = "chkBoxTodos";
            this.chkBoxTodos.Size = new System.Drawing.Size(83, 29);
            this.chkBoxTodos.TabIndex = 7;
            this.chkBoxTodos.Text = "Todos";
            this.chkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblProvincia.Location = new System.Drawing.Point(15, 24);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(208, 41);
            this.lblProvincia.TabIndex = 9;
            this.lblProvincia.Text = "ABM Provincia";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(567, 188);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewProvincias
            // 
            this.dataGridViewProvincias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProvincias.Location = new System.Drawing.Point(7, 231);
            this.dataGridViewProvincias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewProvincias.Name = "dataGridViewProvincias";
            this.dataGridViewProvincias.RowHeadersWidth = 51;
            this.dataGridViewProvincias.RowTemplate.Height = 25;
            this.dataGridViewProvincias.Size = new System.Drawing.Size(671, 292);
            this.dataGridViewProvincias.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Location = new System.Drawing.Point(14, 568);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 57);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(129, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 57);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(640, 568);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 57);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(71, 568);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 57);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Frm_ABM_Provincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 640);
            this.Controls.Add(this.grBoxFiltros);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_ABM_Provincias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Provincia";
            this.grBoxFiltros.ResumeLayout(false);
            this.grBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvincias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxFiltros;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.CheckBox chkBoxTodos;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewProvincias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
    }
}