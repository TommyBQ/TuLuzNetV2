
namespace TuLuzNet.ABMs.TipoDocumento
{
    partial class Frm_ModificarTipoDocumento
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblSiglas = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgregarTipoDocumento = new System.Windows.Forms.Label();
            this.txt_Nombre = new TuLuzNet.Clases.TextBox01();
            this.txt_Siglas = new TuLuzNet.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(293, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(200, 146);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 30);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblSiglas
            // 
            this.lblSiglas.AutoSize = true;
            this.lblSiglas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSiglas.Location = new System.Drawing.Point(12, 104);
            this.lblSiglas.Name = "lblSiglas";
            this.lblSiglas.Size = new System.Drawing.Size(48, 20);
            this.lblSiglas.TabIndex = 29;
            this.lblSiglas.Text = "Siglas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAgregarTipoDocumento
            // 
            this.lblAgregarTipoDocumento.AutoSize = true;
            this.lblAgregarTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarTipoDocumento.Location = new System.Drawing.Point(12, 9);
            this.lblAgregarTipoDocumento.Name = "lblAgregarTipoDocumento";
            this.lblAgregarTipoDocumento.Size = new System.Drawing.Size(302, 32);
            this.lblAgregarTipoDocumento.TabIndex = 26;
            this.lblAgregarTipoDocumento.Text = "Modificar Tipo Documento";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre._columna = "nombre";
            this.txt_Nombre._mensajeError = "No ingreso el nombre";
            this.txt_Nombre._repetible = false;
            this.txt_Nombre._validable = true;
            this.txt_Nombre.Location = new System.Drawing.Point(96, 59);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(123, 23);
            this.txt_Nombre.TabIndex = 32;
            // 
            // txt_Siglas
            // 
            this.txt_Siglas._columna = "siglas";
            this.txt_Siglas._mensajeError = "No ingreso las siglas";
            this.txt_Siglas._repetible = false;
            this.txt_Siglas._validable = true;
            this.txt_Siglas.Location = new System.Drawing.Point(96, 100);
            this.txt_Siglas.Name = "txt_Siglas";
            this.txt_Siglas.Size = new System.Drawing.Size(123, 23);
            this.txt_Siglas.TabIndex = 33;
            // 
            // Frm_ModificarTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 182);
            this.Controls.Add(this.txt_Siglas);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblSiglas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarTipoDocumento);
            this.Name = "Frm_ModificarTipoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Tipo Documento";
            this.Load += new System.EventHandler(this.Frm_ModificarTipoDocumento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblSiglas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarTipoDocumento;
        private Clases.TextBox01 txt_Nombre;
        private Clases.TextBox01 txt_Siglas;
    }
}