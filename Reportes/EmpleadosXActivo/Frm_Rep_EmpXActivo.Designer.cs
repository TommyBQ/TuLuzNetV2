
namespace TuLuzNet.Reportes.EmpleadosXActivo
{
    partial class Frm_Rep_EmpXActivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_EmpXActivo));
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_noActivo = new System.Windows.Forms.RadioButton();
            this.rb_activo = new System.Windows.Forms.RadioButton();
            this.rvEmpXAct = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Reporte: Empleado Por Activo";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(627, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(39, 37);
            this.btnSalir.TabIndex = 148;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.Location = new System.Drawing.Point(240, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 48);
            this.btnBuscar.TabIndex = 147;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(99, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 146;
            this.label1.Text = "Estado";
            // 
            // rb_noActivo
            // 
            this.rb_noActivo.AutoSize = true;
            this.rb_noActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_noActivo.Location = new System.Drawing.Point(102, 104);
            this.rb_noActivo.Name = "rb_noActivo";
            this.rb_noActivo.Size = new System.Drawing.Size(86, 21);
            this.rb_noActivo.TabIndex = 144;
            this.rb_noActivo.TabStop = true;
            this.rb_noActivo.Text = "No Activo";
            this.rb_noActivo.UseVisualStyleBackColor = true;
            // 
            // rb_activo
            // 
            this.rb_activo.AutoSize = true;
            this.rb_activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rb_activo.Location = new System.Drawing.Point(102, 77);
            this.rb_activo.Name = "rb_activo";
            this.rb_activo.Size = new System.Drawing.Size(64, 21);
            this.rb_activo.TabIndex = 145;
            this.rb_activo.TabStop = true;
            this.rb_activo.Text = "Activo";
            this.rb_activo.UseVisualStyleBackColor = true;
            // 
            // rvEmpXAct
            // 
            this.rvEmpXAct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvEmpXAct.Location = new System.Drawing.Point(12, 131);
            this.rvEmpXAct.Name = "rvEmpXAct";
            this.rvEmpXAct.ServerReport.BearerToken = null;
            this.rvEmpXAct.Size = new System.Drawing.Size(654, 307);
            this.rvEmpXAct.TabIndex = 149;
            // 
            // Frm_Rep_EmpXActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.rvEmpXAct);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_noActivo);
            this.Controls.Add(this.rb_activo);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Rep_EmpXActivo";
            this.Text = "Reporte Empleado Por Activo";
            this.Load += new System.EventHandler(this.Frm_Rep_EmpXActivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_noActivo;
        private System.Windows.Forms.RadioButton rb_activo;
        private Microsoft.Reporting.WinForms.ReportViewer rvEmpXAct;
    }
}