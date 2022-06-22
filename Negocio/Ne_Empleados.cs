using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuLuzNet.Clases;
using System.Data;
using System.Windows.Forms;

namespace TuLuzNet.Negocio
{
    public class Ne_Empleados
    {
        public int tipoDoc { get; set; }
        public int numDoc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int codBarrio { get; set; }
        public string telefono { get; set; }
        public int tipoDocJefe { get; set; }
        public int numDocJefe { get; set; }
        public bool activo { get; set; }

        BD_acceso_a_datos _BD_empleados = new BD_acceso_a_datos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public DataTable RecuperarCantEmpleadosActivos()
        {
            string sql = "SELECT activo, COUNT(*) as cantidad FROM [BD3K6G02_2022].[dbo].[Empleados] group by activo";
            return _BD_empleados.EjecutarSQL(sql);
        }

        public EstructuraCombo DatosCombo()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "siglas";
            Ec.Value = "idTipoDoc";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[TipoDocumento]";
            Ec.Tabla = _BD_empleados.EjecutarSQL(Ec.Sql);
            return Ec;
        }
        public EstructuraCombo DatosComboDoc()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "numDoc";
            Ec.Value = "numDoc";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Empleados]";
            Ec.Tabla = _BD_empleados.EjecutarSQL(Ec.Sql);
            return Ec;
        }
        public DataTable RecuperarEmpleados() //Todos los empleados
        {
            string sql = "SELECT * FROM [BD3K6G02_2022].[dbo].[Empleados]";
            return _BD_empleados.EjecutarSQL(sql);
        }
        public DataTable RecuperarEmpleados(string nombre = "", string apellido = "", string numDoc = "", int tipoDoc = -1) // Los empleados por parametro
        {
            System.Data.DataTable rtdo = new DataTable();
            try
            {
                string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Empleados] 
                        WHERE nombre LIKE '" + nombre + "' or apellido LIKE '" + apellido + "' or numDoc = '" + numDoc + "' or tipoDoc = '" + tipoDoc + "';";
                rtdo = _BD_empleados.EjecutarSQL(sql);

            }

            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtdo;
        }
        public void RecargarEmpleado(Control.ControlCollection Controles, DataTable Tabla)
        {
            foreach (var item in Controles)
            {
                string TipoControl = item.GetType().Name;
                if (TipoControl == "TextBox01")
                {
                    TextBox01 txt = item as TextBox01;
                    if (txt._columna == "nombre" || txt._columna == "apellido")
                        txt.Text = _TE.BuscarDato(Tabla, txt._columna);
                }
            }
        }
        public void AltaEmpleados(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "Empleados");
            if (sql != "")
            {
                _BD_empleados.CargarDatos(sql);
            }
            else
                MessageBox.Show("No se cargó el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool ValidarDocumento(string nombreTabla, Control.ControlCollection controles)
        {
            string columna_TD = "";
            string columna_ND = "";
            int text_TD = -1;
            string text_ND = "";
            try
            {
                foreach (var control in controles)
                {
                    string nombre = control.GetType().Name;
                    if (nombre == "TextBox01" && ((TextBox01)control)._columna == "numDoc")
                    {
                        columna_ND = ((TextBox01)control)._columna;
                        text_ND = ((TextBox01)control).Text;
                    }
                    if (nombre == "ComboBox01" && ((ComboBox01)control)._columna == "tipoDoc")
                    {
                        columna_TD = ((ComboBox01)control)._columna;
                        text_TD = ((ComboBox01)control).SelectedIndex;
                    }
                    if (columna_ND != "" && columna_TD != "" && text_TD != -1 && text_ND != "")
                    {
                        DataTable rtdo = new DataTable();
                        string sql = @"SELECT COUNT(*) FROM " + nombreTabla +
                                    " WHERE " + columna_TD + " = " + text_TD + " AND " + columna_ND + " = " + text_ND;
                        rtdo = _BD_empleados.EjecutarSQL(sql);
                        if (rtdo.Rows[0][0].ToString() == "1")
                        {
                            MessageBox.Show("Ese DOCUMENTO ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        return true;
                    }
                }
                MessageBox.Show("Error inesperado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable RecuperarUsuarioXTelefono(string telefono)
        {
            string sql = "SELECT * FROM [BD3K6G02_2022].[dbo].[Empleados] WHERE telefono = '" + telefono + "'";
            return _BD_empleados.EjecutarSQL(sql);
        }
        public DataTable RecuperarTodosEmpleadosXActivo(int estado)
        {
            string sql = @"SELECT E.numDoc, E.apellido, E.nombre, E.direccion, B.nombre as barrio, E.telefono, E.numDocJefe FROM [BD3K6G02_2022].[dbo].[Empleados] AS E JOIN Barrio B ON E.codBarrio = B.codBarrio WHERE activo = " + estado.ToString();
            return _BD_empleados.EjecutarSQL(sql);
        }
        public void Modificar()
        {
            int activoEmpleado = this.activo ? 1 : 0;

            string SqlModificar = "UPDATE Empleados SET ";
            SqlModificar += "tipoDoc = " + this.tipoDoc;
            SqlModificar += ", numDoc =" + this.numDoc;
            SqlModificar += ", nombre = " + _TE.DatosTexto(this.nombre);
            SqlModificar += ", apellido = " + _TE.DatosTexto(this.apellido);
            SqlModificar += ", direccion = " + _TE.DatosTexto(this.direccion);
            SqlModificar += ", codBarrio =" + this.codBarrio;
            SqlModificar += ", telefono =" + _TE.DatosTexto(this.telefono);
            if (this.tipoDocJefe == -1)
            {
                SqlModificar += ", tipoDocJefe = null";
                SqlModificar += ", numDocJefe = null";
            }
            else
            {
                SqlModificar += ", tipoDocJefe =" + this.tipoDocJefe;
                SqlModificar += ", numDocJefe =" + this.numDocJefe;
            }
            SqlModificar += ", activo =" + activoEmpleado;
            SqlModificar += " WHERE numDoc = " + this.numDoc;

            if (_BD_empleados.Modificar(SqlModificar) == BD_acceso_a_datos.TipoEstado.correcto)
                MessageBox.Show("Se modificó correctamente");
            else
                MessageBox.Show("No se modificó, hubo error");

        }

        public void Borrar(string numDoc)
        {
            string SqlBorrar = "DELETE FROM [BD3K6G02_2022].[dbo].[Empleados] WHERE numDoc = " + numDoc;
            if (_BD_empleados.Borrar(SqlBorrar) == BD_acceso_a_datos.TipoEstado.correcto)
                MessageBox.Show("Se borró exitosamente");
            else
                MessageBox.Show("No se borró, hubo error");
        }
    }
}
