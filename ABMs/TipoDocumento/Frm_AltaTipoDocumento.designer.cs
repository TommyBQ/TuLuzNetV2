
namespace TuLuzNet.ABMs.TipoDocumento
{
    partial class Frm_AltaTipoDocumento
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblSiglas = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgregarTipoDocumento = new System.Windows.Forms.Label();
            this.txtNombre = new TuLuzNet.Clases.TextBox01();
            this.txtSiglas = new TuLuzNet.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(293, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(200, 146);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 30);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblSiglas
            // 
            this.lblSiglas.AutoSize = true;
            this.lblSiglas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSiglas.Location = new System.Drawing.Point(12, 104);
            this.lblSiglas.Name = "lblSiglas";
            this.lblSiglas.Size = new System.Drawing.Size(48, 20);
            this.lblSiglas.TabIndex = 21;
            this.lblSiglas.Text = "Siglas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAgregarTipoDocumento
            // 
            this.lblAgregarTipoDocumento.AutoSize = true;
            this.lblAgregarTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarTipoDocumento.Location = new System.Drawing.Point(12, 9);
            this.lblAgregarTipoDocumento.Name = "lblAgregarTipoDocumento";
            this.lblAgregarTipoDocumento.Size = new System.Drawing.Size(285, 32);
            this.lblAgregarTipoDocumento.TabIndex = 18;
            this.lblAgregarTipoDocumento.Text = "Agregar Tipo Documento";
            // 
            // txtNombre
            // 
            this.txtNombre._columna = "nombre";
            this.txtNombre._mensajeError = "No ingreso el nombre";
            this.txtNombre._repetible = false;
            this.txtNombre._validable = true;
            this.txtNombre.Location = new System.Drawing.Point(92, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 23);
            this.txtNombre.TabIndex = 26;
            // 
            // txtSiglas
            // 
            this.txtSiglas._columna = "siglas";
            this.txtSiglas._mensajeError = "No ingreso las siglas";
            this.txtSiglas._repetible = false;
            this.txtSiglas._validable = true;
            this.txtSiglas.Location = new System.Drawing.Point(92, 101);
            this.txtSiglas.Name = "txtSiglas";
            this.txtSiglas.Size = new System.Drawing.Size(142, 23);
            this.txtSiglas.TabIndex = 27;
            // 
            // Frm_AltaTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 187);
            this.Controls.Add(this.txtSiglas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblSiglas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarTipoDocumento);
            this.Name = "Frm_AltaTipoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Tipo Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblSiglas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarTipoDocumento;
        private Clases.TextBox01 txtNombre;
        private Clases.TextBox01 txtSiglas;
    }
}