
namespace TuLuzNet.ABMs.Empleados
{
    partial class Frm_AltaEmpleados
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblTipoDocJefe = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNumDocJefe = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.textBoxNombre = new TuLuzNet.Clases.TextBox01();
            this.textBoxApellido = new TuLuzNet.Clases.TextBox01();
            this.textBoxDireccion = new TuLuzNet.Clases.TextBox01();
            this.textBoxNroDoc = new TuLuzNet.Clases.TextBox01();
            this.textBoxTelefono = new TuLuzNet.Clases.TextBox01();
            this.textBoxNroDocJefe = new TuLuzNet.Clases.TextBox01();
            this.cmbBarrio = new TuLuzNet.Clases.ComboBox01();
            this.cmbTipoDocJefe = new TuLuzNet.Clases.ComboBox01();
            this.cmbTipoDoc = new TuLuzNet.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbActivo = new TuLuzNet.Clases.CheckBox01();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(468, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 26);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAgregar.Location = new System.Drawing.Point(388, 263);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblApellido.Location = new System.Drawing.Point(10, 89);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 31;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombre.Location = new System.Drawing.Point(10, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline);
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(10, 8);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(212, 32);
            this.lblAgregarEmpleado.TabIndex = 28;
            this.lblAgregarEmpleado.Text = "Agregar Empleado";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDireccion.Location = new System.Drawing.Point(10, 157);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 20);
            this.lblDireccion.TabIndex = 41;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBarrio.Location = new System.Drawing.Point(10, 123);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(49, 20);
            this.lblBarrio.TabIndex = 43;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblTipoDocJefe
            // 
            this.lblTipoDocJefe.AutoSize = true;
            this.lblTipoDocJefe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTipoDocJefe.Location = new System.Drawing.Point(10, 215);
            this.lblTipoDocJefe.Name = "lblTipoDocJefe";
            this.lblTipoDocJefe.Size = new System.Drawing.Size(151, 20);
            this.lblTipoDocJefe.TabIndex = 51;
            this.lblTipoDocJefe.Text = "Tipo Documento Jefe";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNumDoc.Location = new System.Drawing.Point(297, 89);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(108, 20);
            this.lblNumDoc.TabIndex = 37;
            this.lblNumDoc.Text = "N° Documento";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTelefono.Location = new System.Drawing.Point(297, 123);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 20);
            this.lblTelefono.TabIndex = 75;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblNumDocJefe
            // 
            this.lblNumDocJefe.AutoSize = true;
            this.lblNumDocJefe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNumDocJefe.Location = new System.Drawing.Point(10, 248);
            this.lblNumDocJefe.Name = "lblNumDocJefe";
            this.lblNumDocJefe.Size = new System.Drawing.Size(138, 20);
            this.lblNumDocJefe.TabIndex = 74;
            this.lblNumDocJefe.Text = "N° Documento Jefe";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTipoDoc.Location = new System.Drawing.Point(297, 54);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(121, 20);
            this.lblTipoDoc.TabIndex = 73;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre._columna = "nombre";
            this.textBoxNombre._mensajeError = "Y el nombre???";
            this.textBoxNombre._repetible = true;
            this.textBoxNombre._validable = true;
            this.textBoxNombre.Location = new System.Drawing.Point(153, 51);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(122, 20);
            this.textBoxNombre.TabIndex = 76;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido._columna = "apellido";
            this.textBoxApellido._mensajeError = "Y el apellido???";
            this.textBoxApellido._repetible = true;
            this.textBoxApellido._validable = true;
            this.textBoxApellido.Location = new System.Drawing.Point(153, 87);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(122, 20);
            this.textBoxApellido.TabIndex = 77;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion._columna = "direccion";
            this.textBoxDireccion._mensajeError = "No tenes casa?";
            this.textBoxDireccion._repetible = true;
            this.textBoxDireccion._validable = true;
            this.textBoxDireccion.Location = new System.Drawing.Point(153, 154);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(122, 20);
            this.textBoxDireccion.TabIndex = 79;
            // 
            // textBoxNroDoc
            // 
            this.textBoxNroDoc._columna = "numDoc";
            this.textBoxNroDoc._mensajeError = "sos un NN";
            this.textBoxNroDoc._repetible = false;
            this.textBoxNroDoc._validable = true;
            this.textBoxNroDoc.Location = new System.Drawing.Point(421, 87);
            this.textBoxNroDoc.Name = "textBoxNroDoc";
            this.textBoxNroDoc.Size = new System.Drawing.Size(122, 20);
            this.textBoxNroDoc.TabIndex = 80;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono._columna = "telefono";
            this.textBoxTelefono._mensajeError = "no tené telefono?";
            this.textBoxTelefono._repetible = false;
            this.textBoxTelefono._validable = true;
            this.textBoxTelefono.Location = new System.Drawing.Point(421, 120);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(122, 20);
            this.textBoxTelefono.TabIndex = 81;
            // 
            // textBoxNroDocJefe
            // 
            this.textBoxNroDocJefe._columna = "numDocJefe";
            this.textBoxNroDocJefe._mensajeError = "No hay jefe";
            this.textBoxNroDocJefe._repetible = true;
            this.textBoxNroDocJefe._validable = false;
            this.textBoxNroDocJefe.Location = new System.Drawing.Point(153, 245);
            this.textBoxNroDocJefe.Name = "textBoxNroDocJefe";
            this.textBoxNroDocJefe.Size = new System.Drawing.Size(122, 20);
            this.textBoxNroDocJefe.TabIndex = 82;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio._columna = "codBarrio";
            this.cmbBarrio._MensajeError = "No cargó Barrio";
            this.cmbBarrio._repetible = true;
            this.cmbBarrio._Validable = true;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(153, 120);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(122, 21);
            this.cmbBarrio.TabIndex = 83;
            // 
            // cmbTipoDocJefe
            // 
            this.cmbTipoDocJefe._columna = "tipoDocJefe";
            this.cmbTipoDocJefe._MensajeError = "No hay tipo doc jefe";
            this.cmbTipoDocJefe._repetible = true;
            this.cmbTipoDocJefe._Validable = false;
            this.cmbTipoDocJefe.FormattingEnabled = true;
            this.cmbTipoDocJefe.Location = new System.Drawing.Point(153, 212);
            this.cmbTipoDocJefe.Name = "cmbTipoDocJefe";
            this.cmbTipoDocJefe.Size = new System.Drawing.Size(122, 21);
            this.cmbTipoDocJefe.TabIndex = 84;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc._columna = "tipoDoc";
            this.cmbTipoDoc._MensajeError = "No cargó Tipo Documento";
            this.cmbTipoDoc._repetible = false;
            this.cmbTipoDoc._Validable = true;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(421, 51);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(122, 21);
            this.cmbTipoDoc.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(297, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Activo";
            // 
            // ckbActivo
            // 
            this.ckbActivo._columna = "activo";
            this.ckbActivo._mensajeError = "No se sabe si esta activo";
            this.ckbActivo._validable = false;
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ckbActivo.Location = new System.Drawing.Point(421, 160);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(15, 14);
            this.ckbActivo.TabIndex = 88;
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // Frm_AltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(549, 294);
            this.Controls.Add(this.ckbActivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.cmbTipoDocJefe);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.textBoxNroDocJefe);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxNroDoc);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNumDocJefe);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblTipoDocJefe);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNumDoc);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(565, 333);
            this.Name = "Frm_AltaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Empleado";
            this.Load += new System.EventHandler(this.Frm_AltaEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarEmpleado;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblTipoDocJefe;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNumDocJefe;
        private System.Windows.Forms.Label lblTipoDoc;
        private Clases.TextBox01 textBoxNombre;
        private Clases.TextBox01 textBoxApellido;
        private Clases.TextBox01 textBoxDireccion;
        private Clases.TextBox01 textBoxNroDoc;
        private Clases.TextBox01 textBoxTelefono;
        private Clases.TextBox01 textBoxNroDocJefe;
        private Clases.ComboBox01 cmbBarrio;
        private Clases.ComboBox01 cmbTipoDocJefe;
        private Clases.ComboBox01 cmbTipoDoc;
        private System.Windows.Forms.Label label1;
        private Clases.CheckBox01 ckbActivo;
    }
}