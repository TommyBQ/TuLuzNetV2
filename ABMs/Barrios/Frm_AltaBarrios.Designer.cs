
namespace TuLuzNet.ABMs.Barrios
{
    partial class Frm_AltaBarrios
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
            this.lblAgregarBarrio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmb_localidades = new TuLuzNet.Clases.ComboBox01();
            this.txt_nombre = new TuLuzNet.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // lblAgregarBarrio
            // 
            this.lblAgregarBarrio.AutoSize = true;
            this.lblAgregarBarrio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarBarrio.Location = new System.Drawing.Point(12, 9);
            this.lblAgregarBarrio.Name = "lblAgregarBarrio";
            this.lblAgregarBarrio.Size = new System.Drawing.Size(167, 32);
            this.lblAgregarBarrio.TabIndex = 10;
            this.lblAgregarBarrio.Text = "Agregar Barrio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocalidad.Location = new System.Drawing.Point(12, 104);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(74, 20);
            this.lblLocalidad.TabIndex = 14;
            this.lblLocalidad.Text = "Localidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(235, 178);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 30);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(347, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmb_localidades
            // 
            this.cmb_localidades._columna = "codLocalidad";
            this.cmb_localidades._MensajeError = "No ingreso la LOCALIDAD";
            this.cmb_localidades._repetible = false;
            this.cmb_localidades._Validable = true;
            this.cmb_localidades.FormattingEnabled = true;
            this.cmb_localidades.Location = new System.Drawing.Point(93, 100);
            this.cmb_localidades.Name = "cmb_localidades";
            this.cmb_localidades.Size = new System.Drawing.Size(141, 23);
            this.cmb_localidades.TabIndex = 18;
            // 
            // txt_nombre
            // 
            this.txt_nombre._columna = "nombre";
            this.txt_nombre._mensajeError = "Ingrese su nombre";
            this.txt_nombre._repetible = false;
            this.txt_nombre._validable = true;
            this.txt_nombre.Location = new System.Drawing.Point(93, 59);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(141, 23);
            this.txt_nombre.TabIndex = 19;
            // 
            // Frm_AltaBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 233);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.cmb_localidades);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarBarrio);
            this.Name = "Frm_AltaBarrios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Barrio";
            this.Load += new System.EventHandler(this.Frm_AltaBarrios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarBarrio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private Clases.ComboBox01 cmb_localidades;
        private Clases.TextBox01 txt_nombre;
    }
}