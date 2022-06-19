
namespace TuLuzNet.ABMs.Pedidos
{
    partial class Frm_ABM_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Pedidos));
            this.grBoxFiltros = new System.Windows.Forms.GroupBox();
            this.cmbTipoDocVendedor = new TuLuzNet.Clases.ComboBox01();
            this.lblTipoDocVendedor = new System.Windows.Forms.Label();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.txtBoxCuitCliente = new System.Windows.Forms.TextBox();
            this.lblNumDocVendedor = new System.Windows.Forms.Label();
            this.chkBoxTodos = new System.Windows.Forms.CheckBox();
            this.txtBoxDocVendedor = new System.Windows.Forms.TextBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.txtBoxNumPedido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxFiltros
            // 
            this.grBoxFiltros.Controls.Add(this.cmbTipoDocVendedor);
            this.grBoxFiltros.Controls.Add(this.lblTipoDocVendedor);
            this.grBoxFiltros.Controls.Add(this.lblCuitCliente);
            this.grBoxFiltros.Controls.Add(this.txtBoxCuitCliente);
            this.grBoxFiltros.Controls.Add(this.lblNumDocVendedor);
            this.grBoxFiltros.Controls.Add(this.chkBoxTodos);
            this.grBoxFiltros.Controls.Add(this.txtBoxDocVendedor);
            this.grBoxFiltros.Controls.Add(this.lblClientes);
            this.grBoxFiltros.Controls.Add(this.lblNumeroPedido);
            this.grBoxFiltros.Controls.Add(this.txtBoxNumPedido);
            this.grBoxFiltros.Controls.Add(this.btnBuscar);
            this.grBoxFiltros.Controls.Add(this.dataGridViewPedidos);
            this.grBoxFiltros.Location = new System.Drawing.Point(1, 3);
            this.grBoxFiltros.Name = "grBoxFiltros";
            this.grBoxFiltros.Size = new System.Drawing.Size(827, 369);
            this.grBoxFiltros.TabIndex = 13;
            this.grBoxFiltros.TabStop = false;
            this.grBoxFiltros.Text = "Filtros";
            this.grBoxFiltros.Enter += new System.EventHandler(this.grBoxFiltros_Enter);
            // 
            // cmbTipoDocVendedor
            // 
            this.cmbTipoDocVendedor._columna = "TipoDocumento";
            this.cmbTipoDocVendedor._MensajeError = null;
            this.cmbTipoDocVendedor._repetible = false;
            this.cmbTipoDocVendedor._Validable = false;
            this.cmbTipoDocVendedor.FormattingEnabled = true;
            this.cmbTipoDocVendedor.Location = new System.Drawing.Point(456, 83);
            this.cmbTipoDocVendedor.Name = "cmbTipoDocVendedor";
            this.cmbTipoDocVendedor.Size = new System.Drawing.Size(126, 21);
            this.cmbTipoDocVendedor.TabIndex = 20;
            this.cmbTipoDocVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocVendedor_SelectedIndexChanged);
            this.cmbTipoDocVendedor.SelectedValueChanged += new System.EventHandler(this.cmbTipoDocVendedor_SelectedValueChanged);
            // 
            // lblTipoDocVendedor
            // 
            this.lblTipoDocVendedor.AutoSize = true;
            this.lblTipoDocVendedor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTipoDocVendedor.Location = new System.Drawing.Point(291, 84);
            this.lblTipoDocVendedor.Name = "lblTipoDocVendedor";
            this.lblTipoDocVendedor.Size = new System.Drawing.Size(159, 20);
            this.lblTipoDocVendedor.TabIndex = 18;
            this.lblTipoDocVendedor.Text = "Tipo de Doc Vendedor";
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCuitCliente.Location = new System.Drawing.Point(15, 84);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(90, 20);
            this.lblCuitCliente.TabIndex = 13;
            this.lblCuitCliente.Text = "CUIT Cliente";
            // 
            // txtBoxCuitCliente
            // 
            this.txtBoxCuitCliente.Location = new System.Drawing.Point(134, 84);
            this.txtBoxCuitCliente.Name = "txtBoxCuitCliente";
            this.txtBoxCuitCliente.Size = new System.Drawing.Size(114, 20);
            this.txtBoxCuitCliente.TabIndex = 12;
            this.txtBoxCuitCliente.Click += new System.EventHandler(this.txtBoxCuitCliente_Click);
            // 
            // lblNumDocVendedor
            // 
            this.lblNumDocVendedor.AutoSize = true;
            this.lblNumDocVendedor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNumDocVendedor.Location = new System.Drawing.Point(291, 58);
            this.lblNumDocVendedor.Name = "lblNumDocVendedor";
            this.lblNumDocVendedor.Size = new System.Drawing.Size(155, 20);
            this.lblNumDocVendedor.TabIndex = 11;
            this.lblNumDocVendedor.Text = "Documento Vendedor";
            // 
            // chkBoxTodos
            // 
            this.chkBoxTodos.AutoSize = true;
            this.chkBoxTodos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkBoxTodos.Location = new System.Drawing.Point(104, 144);
            this.chkBoxTodos.Name = "chkBoxTodos";
            this.chkBoxTodos.Size = new System.Drawing.Size(68, 24);
            this.chkBoxTodos.TabIndex = 7;
            this.chkBoxTodos.Text = "Todos";
            this.chkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // txtBoxDocVendedor
            // 
            this.txtBoxDocVendedor.Location = new System.Drawing.Point(456, 58);
            this.txtBoxDocVendedor.Name = "txtBoxDocVendedor";
            this.txtBoxDocVendedor.Size = new System.Drawing.Size(126, 20);
            this.txtBoxDocVendedor.TabIndex = 10;
            this.txtBoxDocVendedor.Click += new System.EventHandler(this.txtBoxDocVendedor_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline);
            this.lblClientes.Location = new System.Drawing.Point(11, 16);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(156, 32);
            this.lblClientes.TabIndex = 9;
            this.lblClientes.Text = "ABM Pedidos";
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNumeroPedido.Location = new System.Drawing.Point(15, 58);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(113, 20);
            this.lblNumeroPedido.TabIndex = 6;
            this.lblNumeroPedido.Text = "Numero Pedido";
            // 
            // txtBoxNumPedido
            // 
            this.txtBoxNumPedido.Location = new System.Drawing.Point(134, 58);
            this.txtBoxNumPedido.Name = "txtBoxNumPedido";
            this.txtBoxNumPedido.Size = new System.Drawing.Size(114, 20);
            this.txtBoxNumPedido.TabIndex = 5;
            this.txtBoxNumPedido.Click += new System.EventHandler(this.txtBoxNumPedido_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.Location = new System.Drawing.Point(5, 142);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 27);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(5, 175);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowHeadersVisible = false;
            this.dataGridViewPedidos.RowTemplate.Height = 25;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(816, 190);
            this.dataGridViewPedidos.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrar.Location = new System.Drawing.Point(98, 433);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(39, 37);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(54, 433);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(39, 37);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Location = new System.Drawing.Point(11, 433);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(38, 37);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(780, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 37);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_ABM_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grBoxFiltros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ABM_Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Pedidos";
            this.Load += new System.EventHandler(this.Frm_ABM_Pedidos_Load);
            this.grBoxFiltros.ResumeLayout(false);
            this.grBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxFiltros;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.TextBox txtBoxCuitCliente;
        private System.Windows.Forms.Label lblNumDocVendedor;
        private System.Windows.Forms.CheckBox chkBoxTodos;
        private System.Windows.Forms.TextBox txtBoxDocVendedor;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.TextBox txtBoxNumPedido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Label lblTipoDocVendedor;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private Clases.ComboBox01 cmbTipoDocVendedor;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
    }
}