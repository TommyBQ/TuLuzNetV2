
namespace TuLuzNet.ABMs.Localidades
{
    partial class Frm_AltaLocalidades
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
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgregarBarrio = new System.Windows.Forms.Label();
            this.cmb_provincias = new TuLuzNet.Clases.ComboBox01();
            this.txt_nombre = new TuLuzNet.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(249, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAgregar.Location = new System.Drawing.Point(169, 137);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 34);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblProvincia.Location = new System.Drawing.Point(10, 90);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(69, 20);
            this.lblProvincia.TabIndex = 21;
            this.lblProvincia.Text = "Provincia";
            this.lblProvincia.Click += new System.EventHandler(this.lblLocalidad_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombre.Location = new System.Drawing.Point(10, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAgregarBarrio
            // 
            this.lblAgregarBarrio.AutoSize = true;
            this.lblAgregarBarrio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline);
            this.lblAgregarBarrio.Location = new System.Drawing.Point(10, 8);
            this.lblAgregarBarrio.Name = "lblAgregarBarrio";
            this.lblAgregarBarrio.Size = new System.Drawing.Size(206, 32);
            this.lblAgregarBarrio.TabIndex = 18;
            this.lblAgregarBarrio.Text = "Agregar Localidad";
            // 
            // cmb_provincias
            // 
            this.cmb_provincias._columna = "codProvincia";
            this.cmb_provincias._MensajeError = "No ingreso un codigo de provincia";
            this.cmb_provincias._repetible = false;
            this.cmb_provincias._Validable = true;
            this.cmb_provincias.FormattingEnabled = true;
            this.cmb_provincias.Location = new System.Drawing.Point(85, 89);
            this.cmb_provincias.Name = "cmb_provincias";
            this.cmb_provincias.Size = new System.Drawing.Size(122, 21);
            this.cmb_provincias.TabIndex = 25;
            // 
            // txt_nombre
            // 
            this.txt_nombre._columna = "nombre";
            this.txt_nombre._mensajeError = "Ingrese el nombre de la localidad";
            this.txt_nombre._repetible = false;
            this.txt_nombre._validable = true;
            this.txt_nombre.Location = new System.Drawing.Point(85, 55);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(122, 20);
            this.txt_nombre.TabIndex = 26;
            // 
            // Frm_AltaLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 182);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.cmb_provincias);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarBarrio);
            this.Name = "Frm_AltaLocalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Localidades";
            this.Load += new System.EventHandler(this.Frm_AltaLocalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarBarrio;
        private Clases.ComboBox01 cmb_provincias;
        private Clases.TextBox01 txt_nombre;
    }
}