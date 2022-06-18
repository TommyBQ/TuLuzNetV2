
namespace TuLuzNet.ABMs
{
    partial class Frm_ABM_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Productos));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.chkBoxTodos = new System.Windows.Forms.CheckBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblNumeroProducto = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grBoxFiltros = new System.Windows.Forms.GroupBox();
            this.txtNombre = new TuLuzNet.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new TuLuzNet.Clases.Grid01();
            this.txtBoxNumPedido = new TuLuzNet.Clases.TextBox01();
            this.grBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(789, 444);
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
            // chkBoxTodos
            // 
            this.chkBoxTodos.AutoSize = true;
            this.chkBoxTodos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxTodos.Location = new System.Drawing.Point(17, 123);
            this.chkBoxTodos.Name = "chkBoxTodos";
            this.chkBoxTodos.Size = new System.Drawing.Size(68, 24);
            this.chkBoxTodos.TabIndex = 7;
            this.chkBoxTodos.Text = "Todos";
            this.chkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblProductos.Location = new System.Drawing.Point(13, 18);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(178, 32);
            this.lblProductos.TabIndex = 9;
            this.lblProductos.Text = "ABM Productos";
            // 
            // lblNumeroProducto
            // 
            this.lblNumeroProducto.AutoSize = true;
            this.lblNumeroProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroProducto.Location = new System.Drawing.Point(17, 90);
            this.lblNumeroProducto.Name = "lblNumeroProducto";
            this.lblNumeroProducto.Size = new System.Drawing.Size(122, 20);
            this.lblNumeroProducto.TabIndex = 6;
            this.lblNumeroProducto.Text = "Código Producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(725, 148);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 26);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.grBoxFiltros.Controls.Add(this.txtNombre);
            this.grBoxFiltros.Controls.Add(this.label1);
            this.grBoxFiltros.Controls.Add(this.dataGridViewProductos);
            this.grBoxFiltros.Controls.Add(this.txtBoxNumPedido);
            this.grBoxFiltros.Controls.Add(this.chkBoxTodos);
            this.grBoxFiltros.Controls.Add(this.lblProductos);
            this.grBoxFiltros.Controls.Add(this.lblNumeroProducto);
            this.grBoxFiltros.Controls.Add(this.btnBuscar);
            this.grBoxFiltros.Location = new System.Drawing.Point(12, 12);
            this.grBoxFiltros.Name = "grBoxFiltros";
            this.grBoxFiltros.Size = new System.Drawing.Size(837, 436);
            this.grBoxFiltros.TabIndex = 12;
            this.grBoxFiltros.TabStop = false;
            this.grBoxFiltros.Text = "Filtros";
            // 
            // txtNombre
            // 
            this.txtNombre._columna = "nombre";
            this.txtNombre._mensajeError = "No completó nombre.";
            this.txtNombre._repetible = false;
            this.txtNombre._validable = true;
            this.txtNombre.Location = new System.Drawing.Point(150, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 23);
            this.txtNombre.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(13, 180);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowTemplate.Height = 25;
            this.dataGridViewProductos.Size = new System.Drawing.Size(809, 233);
            this.dataGridViewProductos.TabIndex = 11;
            // 
            // txtBoxNumPedido
            // 
            this.txtBoxNumPedido._columna = "codProducto";
            this.txtBoxNumPedido._mensajeError = "No completó codigo producto.";
            this.txtBoxNumPedido._repetible = false;
            this.txtBoxNumPedido._validable = true;
            this.txtBoxNumPedido.Location = new System.Drawing.Point(150, 91);
            this.txtBoxNumPedido.Name = "txtBoxNumPedido";
            this.txtBoxNumPedido.Size = new System.Drawing.Size(144, 23);
            this.txtBoxNumPedido.TabIndex = 10;
            // 
            // Frm_ABM_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 499);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grBoxFiltros);
            this.Name = "Frm_ABM_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Productos";
            this.grBoxFiltros.ResumeLayout(false);
            this.grBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.CheckBox chkBoxTodos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblNumeroProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grBoxFiltros;
        private Clases.TextBox01 txtBoxNumPedido;
        private Clases.TextBox01 txtNombre;
        private System.Windows.Forms.Label label1;
        private Clases.Grid01 dataGridViewProductos;
    }
}