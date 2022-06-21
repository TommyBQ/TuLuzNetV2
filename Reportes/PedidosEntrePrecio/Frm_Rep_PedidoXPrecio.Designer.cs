
namespace TuLuzNet.Reportes.PedidosEntrePrecio
{
    partial class Frm_Rep_PedidoXPrecio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_PedidoXPrecio));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rvPedXPrecio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtPrecioMax = new TuLuzNet.Clases.TextBox01();
            this.txtPrecioMin = new TuLuzNet.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(75, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 153;
            this.label1.Text = " - Precio Minimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(75, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 154;
            this.label4.Text = " - Precio Maximo";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(576, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(39, 37);
            this.btnSalir.TabIndex = 152;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.Location = new System.Drawing.Point(453, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 32);
            this.btnBuscar.TabIndex = 151;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 32);
            this.label2.TabIndex = 150;
            this.label2.Text = "Reporte: Pedidos Entre Precios";
            // 
            // rvPedXPrecio
            // 
            this.rvPedXPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvPedXPrecio.Location = new System.Drawing.Point(12, 120);
            this.rvPedXPrecio.Name = "rvPedXPrecio";
            this.rvPedXPrecio.ServerReport.BearerToken = null;
            this.rvPedXPrecio.Size = new System.Drawing.Size(603, 318);
            this.rvPedXPrecio.TabIndex = 157;
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax._columna = null;
            this.txtPrecioMax._mensajeError = null;
            this.txtPrecioMax._repetible = false;
            this.txtPrecioMax._validable = false;
            this.txtPrecioMax.Location = new System.Drawing.Point(200, 94);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioMax.TabIndex = 156;
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin._columna = null;
            this.txtPrecioMin._mensajeError = null;
            this.txtPrecioMin._repetible = false;
            this.txtPrecioMin._validable = false;
            this.txtPrecioMin.Location = new System.Drawing.Point(200, 59);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioMin.TabIndex = 155;
            // 
            // Frm_Rep_PedidoXPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.rvPedXPrecio);
            this.Controls.Add(this.txtPrecioMax);
            this.Controls.Add(this.txtPrecioMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Rep_PedidoXPrecio";
            this.Text = "Frm_Rep_PedidoXPrecio";
            this.Load += new System.EventHandler(this.Frm_Rep_PedidoXPrecio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clases.TextBox01 txtPrecioMax;
        private Clases.TextBox01 txtPrecioMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rvPedXPrecio;
    }
}