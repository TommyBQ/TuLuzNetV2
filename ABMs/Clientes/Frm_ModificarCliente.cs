using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.Clases;
using TuLuzNet.Negocio;

namespace TuLuzNet.ABMs.Clientes
{
    public partial class Frm_ModificarCliente : Form
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Clientes _NC = new Ne_Clientes();

        public string cuitCliente { get; set; }

        public Frm_ModificarCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //UPDATE[BD3K6G02_2022].[dbo].[Cliente] SET cuitCliente = '20431412528', nombre = 'Danieeel', 
            //    apellido = 'Maldonado', activo = '1' WHERE cuitCliente = '20431412528';
            if (_TE.Validar(this.Controls) == true)
            {
                _NC.CUIT = this.txt_Cuit.Text;
                _NC.apellido = this.txt_Apellido.Text;
                _NC.nombre = this.txt_Nombre.Text;
                if(this.chk_Activo.Checked == true)
                {
                    _NC.activo = ('1').ToString();
                }
                else
                    _NC.activo = ('0').ToString();
                //_NC.activo = this.chk_Activo.Checked ? '1' : '0';
                _NC.Modificar();
            }
            this.Close();
        }

        private void Frm_ModificarCliente_Load(object sender, EventArgs e)
        {
            this.RecuperarCliente();

        }
        private void RecuperarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = _NC.RecuperaPedidoXCliente(cuitCliente);
            _TE.CargarFormulario(this.Controls, tabla);

        }
    }
}
