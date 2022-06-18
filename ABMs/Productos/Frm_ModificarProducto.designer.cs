
namespace TuLuzNet.ABMs.Productos
{
    partial class Frm_ModificarProductos
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
            this.lblModificarEmpleado = new System.Windows.Forms.Label();
            this.txtStock = new TuLuzNet.Clases.TextBox01();
            this.txtPrecio = new TuLuzNet.Clases.TextBox01();
            this.txtNombre = new TuLuzNet.Clases.TextBox01();
            this.cmbProveedor = new TuLuzNet.Clases.ComboBox01();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblCantidadStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbProdComponente = new TuLuzNet.Clases.ComboBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new TuLuzNet.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.chkGenerico = new TuLuzNet.Clases.CheckBox01();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(569, 268);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 40);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(463, 268);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 40);
            this.btnModificar.TabIndex = 74;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblModificarEmpleado
            // 
            this.lblModificarEmpleado.AutoSize = true;
            this.lblModificarEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblModificarEmpleado.Location = new System.Drawing.Point(14, 12);
            this.lblModificarEmpleado.Name = "lblModificarEmpleado";
            this.lblModificarEmpleado.Size = new System.Drawing.Size(273, 41);
            this.lblModificarEmpleado.TabIndex = 70;
            this.lblModificarEmpleado.Text = "Modificar Producto";
            // 
            // txtStock
            // 
            this.txtStock._columna = "cantStock";
            this.txtStock._mensajeError = "No completó Stock.";
            this.txtStock._repetible = false;
            this.txtStock._validable = false;
            this.txtStock.Location = new System.Drawing.Point(483, 135);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(185, 27);
            this.txtStock.TabIndex = 83;
            // 
            // txtPrecio
            // 
            this.txtPrecio._columna = "precio";
            this.txtPrecio._mensajeError = "No completó precio.";
            this.txtPrecio._repetible = false;
            this.txtPrecio._validable = true;
            this.txtPrecio.Location = new System.Drawing.Point(483, 79);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(185, 27);
            this.txtPrecio.TabIndex = 82;
            // 
            // txtNombre
            // 
            this.txtNombre._columna = "nombre";
            this.txtNombre._mensajeError = "No completó nombre.";
            this.txtNombre._repetible = false;
            this.txtNombre._validable = true;
            this.txtNombre.Location = new System.Drawing.Point(113, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 27);
            this.txtNombre.TabIndex = 81;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor._columna = "cuitProveedor";
            this.cmbProveedor._MensajeError = "No eligió proveedor.";
            this.cmbProveedor._repetible = false;
            this.cmbProveedor._Validable = true;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(113, 136);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(155, 28);
            this.cmbProveedor.TabIndex = 80;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProveedor.Location = new System.Drawing.Point(18, 140);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(99, 25);
            this.lblProveedor.TabIndex = 79;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadStock.Location = new System.Drawing.Point(352, 139);
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(137, 25);
            this.lblCantidadStock.TabIndex = 78;
            this.lblCantidadStock.Text = "Cantidad Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(419, 83);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(65, 25);
            this.lblPrecio.TabIndex = 77;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(33, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 76;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbProdComponente
            // 
            this.cmbProdComponente._columna = "codProductoEquivalente";
            this.cmbProdComponente._MensajeError = "No eligió producto componente.";
            this.cmbProdComponente._repetible = false;
            this.cmbProdComponente._Validable = false;
            this.cmbProdComponente.FormattingEnabled = true;
            this.cmbProdComponente.Location = new System.Drawing.Point(483, 195);
            this.cmbProdComponente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProdComponente.Name = "cmbProdComponente";
            this.cmbProdComponente.Size = new System.Drawing.Size(185, 28);
            this.cmbProdComponente.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(295, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 86;
            this.label2.Text = "Producto Componente";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion._columna = "descripcion";
            this.txtDescripcion._mensajeError = "No completó descripcion.";
            this.txtDescripcion._repetible = false;
            this.txtDescripcion._validable = false;
            this.txtDescripcion.Location = new System.Drawing.Point(113, 195);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(155, 27);
            this.txtDescripcion.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Descripcion";
            // 
            // chkGenerico
            // 
            this.chkGenerico._columna = "esGenerico";
            this.chkGenerico._mensajeError = "No selecciono el TIPO COMPONENTE";
            this.chkGenerico._validable = false;
            this.chkGenerico.AutoSize = true;
            this.chkGenerico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGenerico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkGenerico.Location = new System.Drawing.Point(33, 251);
            this.chkGenerico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkGenerico.Name = "chkGenerico";
            this.chkGenerico.Size = new System.Drawing.Size(110, 29);
            this.chkGenerico.TabIndex = 88;
            this.chkGenerico.Text = "Genérico";
            this.chkGenerico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGenerico.UseVisualStyleBackColor = true;
            this.chkGenerico.CheckedChanged += new System.EventHandler(this.chkGenerico_CheckedChanged);
            // 
            // Frm_ModificarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 319);
            this.Controls.Add(this.chkGenerico);
            this.Controls.Add(this.cmbProdComponente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblCantidadStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblModificarEmpleado);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_ModificarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.Frm_ModificarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblModificarEmpleado;
        private Clases.TextBox01 txtStock;
        private Clases.TextBox01 txtPrecio;
        private Clases.TextBox01 txtNombre;
        private Clases.ComboBox01 cmbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblCantidadStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private Clases.ComboBox01 cmbProdComponente;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txtDescripcion;
        private System.Windows.Forms.Label label1;
        private Clases.CheckBox01 chkGenerico;
    }
}