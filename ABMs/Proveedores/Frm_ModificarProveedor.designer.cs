
namespace TuLuzNet.ABMs.Proveedores
{
    partial class Frm_ModificarProveedor
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblModificarProveedores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDProveedor = new TuLuzNet.Clases.TextBox01();
            this.txtRazonSocial = new TuLuzNet.Clases.TextBox01();
            this.txtContacto = new TuLuzNet.Clases.TextBox01();
            this.txtTelefono = new TuLuzNet.Clases.TextBox01();
            this.chkBoxActivo = new TuLuzNet.Clases.CheckBox01();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(283, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Teléfono";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(524, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(431, 172);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 30);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocalidad.Location = new System.Drawing.Point(281, 63);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(69, 20);
            this.lblLocalidad.TabIndex = 31;
            this.lblLocalidad.Text = "Contacto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(7, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 20);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Razón Social";
            // 
            // lblModificarProveedores
            // 
            this.lblModificarProveedores.AutoSize = true;
            this.lblModificarProveedores.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblModificarProveedores.Location = new System.Drawing.Point(7, 9);
            this.lblModificarProveedores.Name = "lblModificarProveedores";
            this.lblModificarProveedores.Size = new System.Drawing.Size(254, 32);
            this.lblModificarProveedores.TabIndex = 28;
            this.lblModificarProveedores.Text = "Modificar Proveedores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID Proveedor";
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor._columna = "cuitProveedor";
            this.txtIDProveedor._mensajeError = "No ingreso el ID";
            this.txtIDProveedor._repetible = false;
            this.txtIDProveedor._validable = false;
            this.txtIDProveedor.Location = new System.Drawing.Point(107, 60);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(142, 23);
            this.txtIDProveedor.TabIndex = 40;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial._columna = "razonSocial";
            this.txtRazonSocial._mensajeError = "No ingreso la RAZON SOCIAL";
            this.txtRazonSocial._repetible = false;
            this.txtRazonSocial._validable = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(107, 106);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(142, 23);
            this.txtRazonSocial.TabIndex = 41;
            // 
            // txtContacto
            // 
            this.txtContacto._columna = "contacto";
            this.txtContacto._mensajeError = "No ingreso el CONTACTO";
            this.txtContacto._repetible = false;
            this.txtContacto._validable = false;
            this.txtContacto.Location = new System.Drawing.Point(356, 60);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(142, 23);
            this.txtContacto.TabIndex = 42;
            // 
            // txtTelefono
            // 
            this.txtTelefono._columna = "telefono";
            this.txtTelefono._mensajeError = "No ingreso el TELEFONO";
            this.txtTelefono._repetible = false;
            this.txtTelefono._validable = false;
            this.txtTelefono.Location = new System.Drawing.Point(356, 104);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(142, 23);
            this.txtTelefono.TabIndex = 43;
            // 
            // chkBoxActivo
            // 
            this.chkBoxActivo._columna = "activo";
            this.chkBoxActivo._mensajeError = null;
            this.chkBoxActivo._validable = false;
            this.chkBoxActivo.AutoSize = true;
            this.chkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxActivo.Location = new System.Drawing.Point(524, 60);
            this.chkBoxActivo.Name = "chkBoxActivo";
            this.chkBoxActivo.Size = new System.Drawing.Size(70, 24);
            this.chkBoxActivo.TabIndex = 44;
            this.chkBoxActivo.Text = "Activo";
            this.chkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // Frm_ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 214);
            this.Controls.Add(this.chkBoxActivo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtIDProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblModificarProveedores);
            this.Name = "Frm_ModificarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Proveedores";
            this.Load += new System.EventHandler(this.Frm_ModificarProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblModificarProveedores;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txtIDProveedor;
        private Clases.TextBox01 txtRazonSocial;
        private Clases.TextBox01 txtContacto;
        private Clases.TextBox01 txtTelefono;
        private Clases.CheckBox01 chkBoxActivo;
    }
}