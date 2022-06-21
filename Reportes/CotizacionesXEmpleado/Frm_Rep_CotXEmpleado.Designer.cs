
namespace TuLuzNet.Reportes.CotizacionesXEmpleado
{
    partial class Frm_Rep_CotXEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_CotXEmpleado));
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rv_cxe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCuit = new TuLuzNet.Clases.ComboBox01();
            this.txtApeEmpleado = new TuLuzNet.Clases.TextBox01();
            this.txtNomEmpleado = new TuLuzNet.Clases.TextBox01();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Reporte: Cotizaciones Por Empleado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.Location = new System.Drawing.Point(471, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 56);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rv_cxe
            // 
            this.rv_cxe.IsDocumentMapWidthFixed = true;
            this.rv_cxe.Location = new System.Drawing.Point(12, 168);
            this.rv_cxe.Name = "rv_cxe";
            this.rv_cxe.ServerReport.BearerToken = null;
            this.rv_cxe.Size = new System.Drawing.Size(776, 377);
            this.rv_cxe.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(233, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = " - Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(233, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 137;
            this.label4.Text = " - Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(39, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 140;
            this.label3.Text = "CUIT";
            // 
            // cmbCuit
            // 
            this.cmbCuit._columna = "numDoc";
            this.cmbCuit._MensajeError = null;
            this.cmbCuit._repetible = false;
            this.cmbCuit._Validable = false;
            this.cmbCuit.FormattingEnabled = true;
            this.cmbCuit.Location = new System.Drawing.Point(85, 84);
            this.cmbCuit.Name = "cmbCuit";
            this.cmbCuit.Size = new System.Drawing.Size(141, 21);
            this.cmbCuit.TabIndex = 141;
            this.cmbCuit.SelectionChangeCommitted += new System.EventHandler(this.cmbCuit_SelectionChangeCommitted);
            // 
            // txtApeEmpleado
            // 
            this.txtApeEmpleado._columna = "apellido";
            this.txtApeEmpleado._mensajeError = "*";
            this.txtApeEmpleado._repetible = false;
            this.txtApeEmpleado._validable = true;
            this.txtApeEmpleado.Location = new System.Drawing.Point(317, 120);
            this.txtApeEmpleado.Name = "txtApeEmpleado";
            this.txtApeEmpleado.ReadOnly = true;
            this.txtApeEmpleado.Size = new System.Drawing.Size(122, 20);
            this.txtApeEmpleado.TabIndex = 139;
            // 
            // txtNomEmpleado
            // 
            this.txtNomEmpleado._columna = "nombre";
            this.txtNomEmpleado._mensajeError = "*";
            this.txtNomEmpleado._repetible = false;
            this.txtNomEmpleado._validable = true;
            this.txtNomEmpleado.Location = new System.Drawing.Point(317, 85);
            this.txtNomEmpleado.Name = "txtNomEmpleado";
            this.txtNomEmpleado.ReadOnly = true;
            this.txtNomEmpleado.Size = new System.Drawing.Size(122, 20);
            this.txtNomEmpleado.TabIndex = 138;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(749, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(39, 37);
            this.btnSalir.TabIndex = 142;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(40, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 143;
            this.label5.Text = "Empleado";
            // 
            // Frm_Rep_CotXEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbCuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApeEmpleado);
            this.Controls.Add(this.txtNomEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rv_cxe);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Rep_CotXEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Frm_Rep_CotXEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer rv_cxe;
        private Clases.TextBox01 txtApeEmpleado;
        private Clases.TextBox01 txtNomEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Clases.ComboBox01 cmbCuit;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
    }
}