
namespace TuLuzNet.Reportes.PedidosXCliente
{
    partial class Frm_Rep_PedidoXCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_PedidoXCli));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCuit = new TuLuzNet.Clases.ComboBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApeEmpleado = new TuLuzNet.Clases.TextBox01();
            this.txtNomEmpleado = new TuLuzNet.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rvPedidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Reporte: Pedidos por Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(18, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 151;
            this.label5.Text = "Cliente";
            // 
            // cmbCuit
            // 
            this.cmbCuit._columna = "cuitCliente";
            this.cmbCuit._MensajeError = null;
            this.cmbCuit._repetible = false;
            this.cmbCuit._Validable = false;
            this.cmbCuit.FormattingEnabled = true;
            this.cmbCuit.Location = new System.Drawing.Point(63, 82);
            this.cmbCuit.Name = "cmbCuit";
            this.cmbCuit.Size = new System.Drawing.Size(141, 21);
            this.cmbCuit.TabIndex = 150;
            this.cmbCuit.SelectionChangeCommitted += new System.EventHandler(this.cmbCuit_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 149;
            this.label3.Text = "CUIT";
            // 
            // txtApeEmpleado
            // 
            this.txtApeEmpleado._columna = "apellidoCliente";
            this.txtApeEmpleado._mensajeError = "*";
            this.txtApeEmpleado._repetible = false;
            this.txtApeEmpleado._validable = true;
            this.txtApeEmpleado.Location = new System.Drawing.Point(295, 118);
            this.txtApeEmpleado.Name = "txtApeEmpleado";
            this.txtApeEmpleado.ReadOnly = true;
            this.txtApeEmpleado.Size = new System.Drawing.Size(122, 20);
            this.txtApeEmpleado.TabIndex = 148;
            // 
            // txtNomEmpleado
            // 
            this.txtNomEmpleado._columna = "nombreCliente";
            this.txtNomEmpleado._mensajeError = "*";
            this.txtNomEmpleado._repetible = false;
            this.txtNomEmpleado._validable = true;
            this.txtNomEmpleado.Location = new System.Drawing.Point(295, 83);
            this.txtNomEmpleado.Name = "txtNomEmpleado";
            this.txtNomEmpleado.ReadOnly = true;
            this.txtNomEmpleado.Size = new System.Drawing.Size(122, 20);
            this.txtNomEmpleado.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(211, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 145;
            this.label1.Text = " - Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(211, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 146;
            this.label4.Text = " - Apellido";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.Location = new System.Drawing.Point(449, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 56);
            this.btnBuscar.TabIndex = 144;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(656, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(39, 37);
            this.btnSalir.TabIndex = 152;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rvPedidos
            // 
            this.rvPedidos.Location = new System.Drawing.Point(12, 153);
            this.rvPedidos.Name = "rvPedidos";
            this.rvPedidos.ServerReport.BearerToken = null;
            this.rvPedidos.Size = new System.Drawing.Size(683, 285);
            this.rvPedidos.TabIndex = 153;
            // 
            // Frm_Rep_PedidoXCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.rvPedidos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApeEmpleado);
            this.Controls.Add(this.txtNomEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Rep_PedidoXCli";
            this.Text = "Frm_Rep_PedidoXCli";
            this.Load += new System.EventHandler(this.Frm_Rep_PedidoXCli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBox01 cmbCuit;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txtApeEmpleado;
        private Clases.TextBox01 txtNomEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer rvPedidos;
    }
}