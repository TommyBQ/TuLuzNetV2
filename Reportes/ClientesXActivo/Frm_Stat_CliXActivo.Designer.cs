
namespace TuLuzNet.Reportes.ClientesXActivo
{
    partial class Frm_Stat_CliXActivo
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
            this.rv_scxa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_scxa
            // 
            this.rv_scxa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_scxa.LocalReport.ReportEmbeddedResource = "TuLuzNet.Reportes.ClientesXActivo.Stat_CliXActivo.rdlc";
            this.rv_scxa.Location = new System.Drawing.Point(0, 0);
            this.rv_scxa.Name = "rv_scxa";
            this.rv_scxa.ServerReport.BearerToken = null;
            this.rv_scxa.Size = new System.Drawing.Size(800, 450);
            this.rv_scxa.TabIndex = 0;
            this.rv_scxa.Load += new System.EventHandler(this.rv_scxa_Load);
            // 
            // Frm_Stat_CliXActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rv_scxa);
            this.Name = "Frm_Stat_CliXActivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística";
            this.Load += new System.EventHandler(this.Frm_Stat_CliXActivo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_scxa;
    }
}