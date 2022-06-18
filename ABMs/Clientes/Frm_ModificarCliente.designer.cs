
namespace TuLuzNet.ABMs.Clientes
{
    partial class Frm_ModificarCliente
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
            this.lblModificarCliente = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txt_Cuit = new TuLuzNet.Clases.TextBox01();
            this.txt_Nombre = new TuLuzNet.Clases.TextBox01();
            this.txt_Apellido = new TuLuzNet.Clases.TextBox01();
            this.chk_Activo = new TuLuzNet.Clases.CheckBox01();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(286, 212);
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
            this.btnModificar.Location = new System.Drawing.Point(193, 212);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 30);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblModificarCliente
            // 
            this.lblModificarCliente.AutoSize = true;
            this.lblModificarCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblModificarCliente.Location = new System.Drawing.Point(12, 9);
            this.lblModificarCliente.Name = "lblModificarCliente";
            this.lblModificarCliente.Size = new System.Drawing.Size(197, 32);
            this.lblModificarCliente.TabIndex = 27;
            this.lblModificarCliente.Text = "Modificar Cliente";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuit.Location = new System.Drawing.Point(18, 56);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(40, 20);
            this.lblCuit.TabIndex = 38;
            this.lblCuit.Text = "CUIT";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(18, 136);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 36;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(18, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre";
            // 
            // txt_Cuit
            // 
            this.txt_Cuit._columna = "cuitCliente";
            this.txt_Cuit._mensajeError = "No ingreso el CUIT";
            this.txt_Cuit._repetible = false;
            this.txt_Cuit._validable = true;
            this.txt_Cuit.Location = new System.Drawing.Point(101, 52);
            this.txt_Cuit.Name = "txt_Cuit";
            this.txt_Cuit.Size = new System.Drawing.Size(147, 23);
            this.txt_Cuit.TabIndex = 39;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre._columna = "nombre";
            this.txt_Nombre._mensajeError = "No ingreso el NOMBRE";
            this.txt_Nombre._repetible = false;
            this.txt_Nombre._validable = true;
            this.txt_Nombre.Location = new System.Drawing.Point(101, 91);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(147, 23);
            this.txt_Nombre.TabIndex = 40;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido._columna = "apellido";
            this.txt_Apellido._mensajeError = "No ingreso el APELLIDO";
            this.txt_Apellido._repetible = false;
            this.txt_Apellido._validable = true;
            this.txt_Apellido.Location = new System.Drawing.Point(101, 136);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(147, 23);
            this.txt_Apellido.TabIndex = 41;
            // 
            // chk_Activo
            // 
            this.chk_Activo._columna = "activo";
            this.chk_Activo._mensajeError = "No selecciono el ESTADO";
            this.chk_Activo._validable = true;
            this.chk_Activo.AutoSize = true;
            this.chk_Activo.Location = new System.Drawing.Point(18, 195);
            this.chk_Activo.Name = "chk_Activo";
            this.chk_Activo.Size = new System.Drawing.Size(60, 19);
            this.chk_Activo.TabIndex = 42;
            this.chk_Activo.Text = "Activo";
            this.chk_Activo.UseVisualStyleBackColor = true;
            // 
            // Frm_ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 249);
            this.Controls.Add(this.chk_Activo);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Cuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblModificarCliente);
            this.Name = "Frm_ModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente";
            this.Load += new System.EventHandler(this.Frm_ModificarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblModificarCliente;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private Clases.TextBox01 txt_Cuit;
        private Clases.TextBox01 txt_Nombre;
        private Clases.TextBox01 txt_Apellido;
        private Clases.CheckBox01 chk_Activo;
    }
}