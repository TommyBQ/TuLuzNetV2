
namespace TuLuzNet.Reportes.CotizacionesXEmpleado
{
    partial class Frm_Stat_CotXEmpleado
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
            this.rv_scxe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_scxe
            // 
            this.rv_scxe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_scxe.LocalReport.ReportEmbeddedResource = "TuLuzNet.Reportes.CotizacionesXEmpleado.Stat_CotXEmpleado.rdlc";
            this.rv_scxe.Location = new System.Drawing.Point(0, 0);
            this.rv_scxe.Name = "rv_scxe";
            this.rv_scxe.ServerReport.BearerToken = null;
            this.rv_scxe.Size = new System.Drawing.Size(800, 450);
            this.rv_scxe.TabIndex = 0;
            this.rv_scxe.Load += new System.EventHandler(this.rv_scxe_Load);
            // 
            // Frm_Stat_CotXEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rv_scxe);
            this.Name = "Frm_Stat_CotXEmpleado";
            this.Text = "Estadística";
            this.Load += new System.EventHandler(this.Frm_Stat_CotXEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_scxe;
    }
}