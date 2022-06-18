
namespace TuLuzNet.ABMs.Proveedores
{
    partial class Frm_AltaProveedores
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
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgregarBarrio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCUIT = new TuLuzNet.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new TuLuzNet.Clases.CheckBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new TuLuzNet.Clases.TextBox01();
            this.txtContacto = new TuLuzNet.Clases.TextBox01();
            this.txtRazonSocial = new TuLuzNet.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(418, 188);
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
            this.btnAgregar.Location = new System.Drawing.Point(325, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 30);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocalidad.Location = new System.Drawing.Point(291, 115);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(69, 20);
            this.lblLocalidad.TabIndex = 21;
            this.lblLocalidad.Text = "Contacto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Razón Social";
            // 
            // lblAgregarBarrio
            // 
            this.lblAgregarBarrio.AutoSize = true;
            this.lblAgregarBarrio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarBarrio.Location = new System.Drawing.Point(12, 9);
            this.lblAgregarBarrio.Name = "lblAgregarBarrio";
            this.lblAgregarBarrio.Size = new System.Drawing.Size(237, 32);
            this.lblAgregarBarrio.TabIndex = 18;
            this.lblAgregarBarrio.Text = "Agregar Proveedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(293, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Teléfono";
            // 
            // txtCUIT
            // 
            this.txtCUIT._columna = "cuitProveedor";
            this.txtCUIT._mensajeError = "No ingreso el CUIT";
            this.txtCUIT._repetible = false;
            this.txtCUIT._validable = true;
            this.txtCUIT.Location = new System.Drawing.Point(120, 64);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(142, 23);
            this.txtCUIT.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "CUIT";
            // 
            // chkActivo
            // 
            this.chkActivo._columna = "activo";
            this.chkActivo._mensajeError = null;
            this.chkActivo._validable = true;
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(120, 163);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(15, 14);
            this.chkActivo.TabIndex = 30;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Activo";
            // 
            // txtTelefono
            // 
            this.txtTelefono._columna = "telefono";
            this.txtTelefono._mensajeError = "No ingreso el TELEFONO";
            this.txtTelefono._repetible = true;
            this.txtTelefono._validable = true;
            this.txtTelefono.Location = new System.Drawing.Point(366, 60);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(139, 23);
            this.txtTelefono.TabIndex = 32;
            // 
            // txtContacto
            // 
            this.txtContacto._columna = "contacto";
            this.txtContacto._mensajeError = "No ingreso el CONTACTO";
            this.txtContacto._repetible = true;
            this.txtContacto._validable = true;
            this.txtContacto.Location = new System.Drawing.Point(366, 115);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(139, 23);
            this.txtContacto.TabIndex = 33;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial._columna = "razonSocial";
            this.txtRazonSocial._mensajeError = "No ingreso la RAZON SOCIAL";
            this.txtRazonSocial._repetible = true;
            this.txtRazonSocial._validable = true;
            this.txtRazonSocial.Location = new System.Drawing.Point(120, 115);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(139, 23);
            this.txtRazonSocial.TabIndex = 34;
            // 
            // Frm_AltaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 230);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarBarrio);
            this.Name = "Frm_AltaProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Proveedores";
            this.Load += new System.EventHandler(this.Frm_AltaProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarBarrio;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txtCUIT;
        private System.Windows.Forms.Label label1;
        private Clases.CheckBox01 chkActivo;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txtTelefono;
        private Clases.TextBox01 txtContacto;
        private Clases.TextBox01 txtRazonSocial;
    }
}