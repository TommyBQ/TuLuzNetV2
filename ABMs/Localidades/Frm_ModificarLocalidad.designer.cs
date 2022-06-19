
namespace TuLuzNet.ABMs.Localidades
{
    partial class Frm_ModificarLocalidad
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
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgregarBarrio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_provincias = new TuLuzNet.Clases.ComboBox01();
            this.txt_localidad = new TuLuzNet.Clases.TextBox01();
            this.txt_nombre = new TuLuzNet.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(250, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 29);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnModificar.Location = new System.Drawing.Point(160, 149);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 29);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblProvincia.Location = new System.Drawing.Point(10, 120);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(69, 20);
            this.lblProvincia.TabIndex = 28;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombre.Location = new System.Drawing.Point(10, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAgregarBarrio
            // 
            this.lblAgregarBarrio.AutoSize = true;
            this.lblAgregarBarrio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline);
            this.lblAgregarBarrio.Location = new System.Drawing.Point(10, 8);
            this.lblAgregarBarrio.Name = "lblAgregarBarrio";
            this.lblAgregarBarrio.Size = new System.Drawing.Size(223, 32);
            this.lblAgregarBarrio.TabIndex = 25;
            this.lblAgregarBarrio.Text = "Modificar Localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID Localidad";
            // 
            // cmb_provincias
            // 
            this.cmb_provincias._columna = "codProvincia";
            this.cmb_provincias._MensajeError = "No ingreso la PROVINCIA";
            this.cmb_provincias._repetible = false;
            this.cmb_provincias._Validable = true;
            this.cmb_provincias.FormattingEnabled = true;
            this.cmb_provincias.Location = new System.Drawing.Point(109, 119);
            this.cmb_provincias.Name = "cmb_provincias";
            this.cmb_provincias.Size = new System.Drawing.Size(122, 21);
            this.cmb_provincias.TabIndex = 34;
            // 
            // txt_localidad
            // 
            this.txt_localidad._columna = "codLocalidad";
            this.txt_localidad._mensajeError = "No ingreso el ID ";
            this.txt_localidad._repetible = false;
            this.txt_localidad._validable = true;
            this.txt_localidad.Location = new System.Drawing.Point(109, 49);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(122, 20);
            this.txt_localidad.TabIndex = 35;
            // 
            // txt_nombre
            // 
            this.txt_nombre._columna = "nombre";
            this.txt_nombre._mensajeError = "No ingreso el NOMBRE";
            this.txt_nombre._repetible = false;
            this.txt_nombre._validable = true;
            this.txt_nombre.Location = new System.Drawing.Point(109, 84);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(122, 20);
            this.txt_nombre.TabIndex = 36;
            // 
            // Frm_ModificarLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 186);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_localidad);
            this.Controls.Add(this.cmb_provincias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarBarrio);
            this.Name = "Frm_ModificarLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Localidad";
            this.Load += new System.EventHandler(this.Frm_ModificarLocalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarBarrio;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_provincias;
        private Clases.TextBox01 txt_localidad;
        private Clases.TextBox01 txt_nombre;
    }
}