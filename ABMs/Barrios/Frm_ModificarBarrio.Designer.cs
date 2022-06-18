
namespace TuLuzNet.ABMs.Barrios
{
    partial class Frm_ModificarBarrio
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
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblModificarBarrio = new System.Windows.Forms.Label();
            this.lblCodigoBarrio = new System.Windows.Forms.Label();
            this.cmb_localidades1 = new TuLuzNet.Clases.ComboBox01();
            this.txtCodigoBarrio = new TuLuzNet.Clases.TextBox01();
            this.txtNombre = new TuLuzNet.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(291, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(198, 189);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 30);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocalidad.Location = new System.Drawing.Point(11, 134);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(74, 20);
            this.lblLocalidad.TabIndex = 21;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(11, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblModificarBarrio
            // 
            this.lblModificarBarrio.AutoSize = true;
            this.lblModificarBarrio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblModificarBarrio.Location = new System.Drawing.Point(12, 9);
            this.lblModificarBarrio.Name = "lblModificarBarrio";
            this.lblModificarBarrio.Size = new System.Drawing.Size(184, 32);
            this.lblModificarBarrio.TabIndex = 18;
            this.lblModificarBarrio.Text = "Modificar Barrio";
            // 
            // lblCodigoBarrio
            // 
            this.lblCodigoBarrio.AutoSize = true;
            this.lblCodigoBarrio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoBarrio.Location = new System.Drawing.Point(11, 55);
            this.lblCodigoBarrio.Name = "lblCodigoBarrio";
            this.lblCodigoBarrio.Size = new System.Drawing.Size(68, 20);
            this.lblCodigoBarrio.TabIndex = 25;
            this.lblCodigoBarrio.Text = "ID Barrio";
            // 
            // cmb_localidades1
            // 
            this.cmb_localidades1._columna = "codLocalidad";
            this.cmb_localidades1._MensajeError = "No selecciono la LOCALIDAD";
            this.cmb_localidades1._repetible = false;
            this.cmb_localidades1._Validable = false;
            this.cmb_localidades1.FormattingEnabled = true;
            this.cmb_localidades1.Location = new System.Drawing.Point(91, 134);
            this.cmb_localidades1.Name = "cmb_localidades1";
            this.cmb_localidades1.Size = new System.Drawing.Size(142, 23);
            this.cmb_localidades1.TabIndex = 27;
            // 
            // txtCodigoBarrio
            // 
            this.txtCodigoBarrio._columna = "codBarrio";
            this.txtCodigoBarrio._mensajeError = "No ingreso el ID";
            this.txtCodigoBarrio._repetible = false;
            this.txtCodigoBarrio._validable = true;
            this.txtCodigoBarrio.Location = new System.Drawing.Point(91, 51);
            this.txtCodigoBarrio.Name = "txtCodigoBarrio";
            this.txtCodigoBarrio.Size = new System.Drawing.Size(142, 23);
            this.txtCodigoBarrio.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre._columna = "nombre";
            this.txtNombre._mensajeError = "No ingreso el NOMBRE";
            this.txtNombre._repetible = false;
            this.txtNombre._validable = true;
            this.txtNombre.Location = new System.Drawing.Point(91, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 23);
            this.txtNombre.TabIndex = 29;
            // 
            // Frm_ModificarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 229);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoBarrio);
            this.Controls.Add(this.cmb_localidades1);
            this.Controls.Add(this.lblCodigoBarrio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblModificarBarrio);
            this.Name = "Frm_ModificarBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Barrio";
            this.Load += new System.EventHandler(this.Frm_ModificarBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblModificarBarrio;
        private System.Windows.Forms.Label lblCodigoBarrio;
        private Clases.ComboBox01 cmb_localidades1;
        private Clases.TextBox01 txtCodigoBarrio;
        private Clases.TextBox01 txtNombre;
    }
}