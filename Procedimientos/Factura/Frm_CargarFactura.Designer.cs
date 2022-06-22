
namespace TuLuzNet.Procedimientos.Factura
{
    partial class Frm_CargarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CargarFactura));
            this.textBox011 = new TuLuzNet.Clases.TextBox01();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.grBoxFiltros = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.chkNoActivo = new TuLuzNet.Clases.CheckBox01();
            this.chkActivo = new TuLuzNet.Clases.CheckBox01();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrarLogico = new System.Windows.Forms.Button();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewFactura = new TuLuzNet.Clases.Grid01();
            this.txtNumFactura = new TuLuzNet.Clases.TextBox01();
            this.grBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox011
            // 
            this.textBox011._columna = null;
            this.textBox011._mensajeError = null;
            this.textBox011._repetible = false;
            this.textBox011._validable = false;
            this.textBox011.Location = new System.Drawing.Point(71, 72);
            this.textBox011.Name = "textBox011";
            this.textBox011.Size = new System.Drawing.Size(114, 20);
            this.textBox011.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombre.Location = new System.Drawing.Point(5, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 20);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "N° Factura";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline);
            this.lblBarrio.Location = new System.Drawing.Point(5, 16);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(159, 32);
            this.lblBarrio.TabIndex = 15;
            this.lblBarrio.Text = "ABM Facturas";
            // 
            // grBoxFiltros
            // 
            this.grBoxFiltros.Controls.Add(this.btnEditar);
            this.grBoxFiltros.Controls.Add(this.chkNoActivo);
            this.grBoxFiltros.Controls.Add(this.chkActivo);
            this.grBoxFiltros.Controls.Add(this.btnVolver);
            this.grBoxFiltros.Controls.Add(this.btnAgregar);
            this.grBoxFiltros.Controls.Add(this.btnBorrarLogico);
            this.grBoxFiltros.Controls.Add(this.btnBuscarTodos);
            this.grBoxFiltros.Controls.Add(this.btnBuscar);
            this.grBoxFiltros.Controls.Add(this.dataGridViewFactura);
            this.grBoxFiltros.Controls.Add(this.txtNumFactura);
            this.grBoxFiltros.Controls.Add(this.lblBarrio);
            this.grBoxFiltros.Controls.Add(this.lblNombre);
            this.grBoxFiltros.Location = new System.Drawing.Point(10, 10);
            this.grBoxFiltros.Name = "grBoxFiltros";
            this.grBoxFiltros.Size = new System.Drawing.Size(627, 378);
            this.grBoxFiltros.TabIndex = 18;
            this.grBoxFiltros.TabStop = false;
            this.grBoxFiltros.Text = "Filtros";
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(49, 335);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(39, 37);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // chkNoActivo
            // 
            this.chkNoActivo._columna = "activo";
            this.chkNoActivo._mensajeError = null;
            this.chkNoActivo._validable = false;
            this.chkNoActivo.AutoSize = true;
            this.chkNoActivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkNoActivo.Location = new System.Drawing.Point(213, 68);
            this.chkNoActivo.Name = "chkNoActivo";
            this.chkNoActivo.Size = new System.Drawing.Size(97, 25);
            this.chkNoActivo.TabIndex = 24;
            this.chkNoActivo.Text = "No Activo";
            this.chkNoActivo.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo._columna = "activo";
            this.chkActivo._mensajeError = null;
            this.chkActivo._validable = false;
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkActivo.Location = new System.Drawing.Point(213, 41);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(72, 25);
            this.chkActivo.TabIndex = 23;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.Location = new System.Drawing.Point(581, 335);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(39, 37);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Location = new System.Drawing.Point(5, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(38, 37);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrarLogico
            // 
            this.btnBorrarLogico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarLogico.BackgroundImage")));
            this.btnBorrarLogico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarLogico.Location = new System.Drawing.Point(94, 335);
            this.btnBorrarLogico.Name = "btnBorrarLogico";
            this.btnBorrarLogico.Size = new System.Drawing.Size(39, 37);
            this.btnBorrarLogico.TabIndex = 21;
            this.btnBorrarLogico.UseVisualStyleBackColor = true;
            this.btnBorrarLogico.Click += new System.EventHandler(this.btnBorrarLogico_Click);
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscarTodos.Location = new System.Drawing.Point(423, 79);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(108, 26);
            this.btnBuscarTodos.TabIndex = 19;
            this.btnBuscarTodos.Text = "Buscar Todos";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.Location = new System.Drawing.Point(537, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 26);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewFactura
            // 
            this.dataGridViewFactura.AllowUserToAddRows = false;
            this.dataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactura.Location = new System.Drawing.Point(5, 110);
            this.dataGridViewFactura.Name = "dataGridViewFactura";
            this.dataGridViewFactura.RowHeadersVisible = false;
            this.dataGridViewFactura.RowTemplate.Height = 25;
            this.dataGridViewFactura.Size = new System.Drawing.Size(615, 219);
            this.dataGridViewFactura.TabIndex = 17;
            this.dataGridViewFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFactura_CellContentClick);
            // 
            // txtNumFactura
            // 
            this.txtNumFactura._columna = "numeroFactura";
            this.txtNumFactura._mensajeError = null;
            this.txtNumFactura._repetible = false;
            this.txtNumFactura._validable = false;
            this.txtNumFactura.Location = new System.Drawing.Point(81, 62);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(121, 20);
            this.txtNumFactura.TabIndex = 16;
            // 
            // Frm_CargarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 399);
            this.Controls.Add(this.grBoxFiltros);
            this.Controls.Add(this.textBox011);
            this.Name = "Frm_CargarFactura";
            this.Text = "Cargar Factura";
            this.Load += new System.EventHandler(this.Frm_CargarFactura_Load);
            this.grBoxFiltros.ResumeLayout(false);
            this.grBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.GroupBox grBoxFiltros;
        private Clases.Grid01 dataGridViewFactura;
        private Clases.TextBox01 txtNumFactura;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrarLogico;
        private System.Windows.Forms.Button btnVolver;
        private Clases.CheckBox01 chkActivo;
        private Clases.CheckBox01 chkNoActivo;
        private System.Windows.Forms.Button btnEditar;
    }
}