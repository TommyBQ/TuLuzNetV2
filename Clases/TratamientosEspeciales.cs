using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuzNet.Negocio;

namespace TuLuzNet.Clases
{
    public class TratamientosEspeciales
    {
        public enum RespustaValidacion { error, correcta }
        BD_acceso_a_datos _BD = new BD_acceso_a_datos();

        public object exit { get; private set; }

        public bool controlar(Control.ControlCollection controles, string nombreTabla)
        {

            foreach (var control in controles)
            {
                string nombre = control.GetType().Name;
                if (nombre == "TextBox01")
                {
                    if (((TextBox01)control)._repetible == false)
                        if (ValidarNoRepeticion(nombreTabla, ((TextBox01)control)._columna, ((TextBox01)control).Text, controles) == false)
                            return false;
                    if (((TextBox01)control)._validable == true)
                    {
                        if (((TextBox01)control).Text == "")
                        {
                            //MessageBox.Show("Error", "error");
                            MessageBox.Show(((TextBox01)control)._mensajeError.ToString());
                            ((TextBox01)control).Focus();
                            return false;
                        }
                    }

                }
                if (nombre == "ComboBox01")
                {
                    if (((ComboBox01)control)._Validable == true)
                    {
                        if (((ComboBox01)control).SelectedIndex == -1)
                        {
                            MessageBox.Show(((ComboBox01)control)._MensajeError.ToString());
                            ((ComboBox01)control).Focus();
                            return false;
                        }
                    }
                }
            }

            return true;
        }
        public bool Validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                string TipoControl = item.GetType().Name;
                if (TipoControl == "TextBox01")
                {
                    TextBox01 TB = item as TextBox01;
                    if (TB._validable == true)
                    {
                        if (TB.Text == "")
                        {
                            MessageBox.Show(TB._mensajeError);
                            TB.Focus();
                            return false;
                        }
                    }
                }
                if (TipoControl == "ComboBox01")
                {
                    if (((ComboBox01)item)._Validable == true)
                    {
                        if (((ComboBox01)item).SelectedIndex == -1)
                        {
                            MessageBox.Show(((ComboBox01)item)._MensajeError);
                            ((ComboBox01)item).Focus();
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public string DatosTexto(string dato)
        {
            return "'" + dato.Trim() + "'";
        }
        public string DatoFecha(string dato)
        {
            return "CONVERT(date, '" + dato.Trim() + "', 103)";
        }

        public string InsertarDatos(Control.ControlCollection controles, string nombreTabla)
        {
            string querry = "INSERT INTO " + nombreTabla + " (";
            string columnasQuerry = "";
            string datosQuerry = "";

            foreach (var control in controles)
            {
                string tipoControl = control.GetType().Name;
                if (tipoControl == "TextBox01") //HAY Q VALIDAR Q NO SE REPITA, telefono y tipodoc numdoc
                {
                    if (((TextBox01)control)._validable == true)
                    {
                        if (ValidarColumna(nombreTabla, ((TextBox01)control)._columna) == false)
                            continue;
                        if (columnasQuerry == "")
                        {
                            columnasQuerry += ((TextBox01)control)._columna;
                            datosQuerry += FormateaDato(nombreTabla, ((TextBox01)control)._columna, ((TextBox01)control).Text);
                        }
                        else
                        {
                            columnasQuerry += "," + ((TextBox01)control)._columna;
                            datosQuerry += "," + FormateaDato(nombreTabla, ((TextBox01)control)._columna, ((TextBox01)control).Text);
                        }
                    }
                    else // NUMERO DOC Jefe... tenemos que validar q exista el TIPO y NUM del DOC del JEFE cargado
                    {
                        if (((TextBox01)control).Text == "")
                            continue;
                        //carga de datos cuando no son obligatorios tiene q preguntar si esta vacios ---> Numero de documento del jefe
                        if (ValidarColumna(nombreTabla, ((TextBox01)control)._columna) == false)
                            continue;
                        if (columnasQuerry == "")
                        {
                            columnasQuerry += ((TextBox01)control)._columna;
                            datosQuerry += FormateaDato(nombreTabla, ((TextBox01)control)._columna, ((TextBox01)control).Text);
                        }
                        else
                        {
                            columnasQuerry += "," + ((TextBox01)control)._columna;
                            datosQuerry += "," + FormateaDato(nombreTabla, ((TextBox01)control)._columna, ((TextBox01)control).Text);
                        }
                    }
                }
                if (tipoControl == "ComboBox01")
                {
                    if (((ComboBox01)control)._Validable == true)
                    {
                        if (ValidarColumna(nombreTabla, ((ComboBox01)control)._columna) == false)
                            continue;
                        if (columnasQuerry == "")
                        {
                            columnasQuerry += ((ComboBox01)control)._columna;
                            datosQuerry += FormateaDato(nombreTabla, ((ComboBox01)control)._columna, ((ComboBox01)control).SelectedValue.ToString());
                        }
                        else
                        {
                            columnasQuerry += "," + ((ComboBox01)control)._columna;
                            datosQuerry += "," + FormateaDato(nombreTabla, ((ComboBox01)control)._columna, ((ComboBox01)control).SelectedValue.ToString());
                        }
                    }
                    else
                    {
                        if (((ComboBox01)control).SelectedIndex == -1)
                            continue;
                        //carga de datos cuando no son obligatorios tiene q preguntar si esta vacios ---> Tipo de documento del jefe
                        if (ValidarColumna(nombreTabla, ((ComboBox01)control)._columna) == false)
                            continue;
                        if (columnasQuerry == "")
                        {
                            columnasQuerry += ((ComboBox01)control)._columna;
                            datosQuerry += FormateaDato(nombreTabla, ((ComboBox01)control)._columna, ((ComboBox01)control).SelectedValue.ToString());
                        }
                        else
                        {
                            columnasQuerry += "," + ((ComboBox01)control)._columna;
                            datosQuerry += "," + FormateaDato(nombreTabla, ((ComboBox01)control)._columna, ((ComboBox01)control).SelectedValue.ToString());
                        }
                    }
                }
                if (tipoControl == "CheckBox01")
                {
                    if (((CheckBox01)control).Checked)
                    {
                        if (ValidarColumna(nombreTabla, ((CheckBox01)control)._columna) == false)
                            continue;
                        if (columnasQuerry == "")
                        {
                            columnasQuerry += ((CheckBox01)control)._columna;
                            datosQuerry += 1;
                        }
                        else
                        {
                            columnasQuerry += "," + ((CheckBox01)control)._columna;
                            datosQuerry += "," + 1;
                        }
                    }
                    else
                    {
                        if (columnasQuerry == "")
                        {
                            columnasQuerry += ((CheckBox01)control)._columna;
                            datosQuerry += 0;
                        }
                        else
                        {
                            columnasQuerry += "," + ((CheckBox01)control)._columna;
                            datosQuerry += "," + 0;
                        }
                    }
                }
            }
            querry += columnasQuerry + ") values (" + datosQuerry + ")";
            return querry;
        }

        private bool ValidarNoRepeticion(string nombreTabla, string columna, string text, Control.ControlCollection controles)
        {
            if (nombreTabla == "[BD3K6G02_2022].[dbo].[Empleados]")
            {
                Ne_Empleados _NE = new Ne_Empleados();
                if (_NE.ValidarDocumento(nombreTabla, controles) == false)
                    return false;
            }

            DataTable rtdo = new DataTable();
            string sql = @"SELECT COUNT(*) FROM " + nombreTabla + " WHERE " + columna + " = '" + text + "'";
            rtdo = _BD.EjecutarSQL(sql);
            if (rtdo.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("El valor del campo '" + columna.ToUpper() + "' Ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private bool ValidarColumna(string Tabla, string Columna)
        {
            DataTable Estructura = new DataTable();
            Estructura = EstructuraTabla(Tabla);
            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                if (Columna.Trim().ToUpper() == Estructura.Columns[i].Caption.Trim().ToUpper())
                    return true;
            }
            return false;
        }

        private string FormateaDato(string Tabla, string Columna, string Datos)
        {
            DataTable Estructura = new DataTable();
            Estructura = EstructuraTabla(Tabla);
            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                if (Estructura.Columns[i].Caption.Trim().ToUpper() == Columna.Trim().ToUpper())
                {
                    switch (Estructura.Columns[i].DataType.Name)
                    {
                        case "Int32":
                        case "Int64":
                        case "Int16":
                            return Datos;
                        case "String":
                            return "'" + Datos + "'";
                        case "Date":
                        case "DateTime":
                            return "CONVERT(date, '" + Datos + "',103)";
                    }
                }
            }
            return Datos;
        }

        private DataTable EstructuraTabla(string NombreTabla)
        {
            string sql = "SELECT TOP 1 * FROM " + NombreTabla;
            return _BD.EjecutarSQL(sql);
        }

        public void CargarFormulario(Control.ControlCollection Controles, DataTable Tabla)
        {
            foreach (var item in Controles)
            {
                string TipoControl = item.GetType().Name;
                if (TipoControl == "DateTimePicker01")
                {
                    DateTimePicker01 dtp = item as DateTimePicker01;
                    DateTime valor= Convert.ToDateTime(BuscarDato(Tabla, dtp._columna));
                    if (valor < dtp.MinDate || valor > dtp.MaxDate)
                    {
                        dtp.Value = dtp.MinDate;
                        MessageBox.Show("La fecha almacenada exede los limites de guardado. \nSe estableció el mínimo por defecto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dtp.Value = valor;
                    }
                }
                if (TipoControl == "TextBox01")
                {
                    TextBox01 txt = item as TextBox01;
                    if (txt._validable == true)
                        txt.Text = BuscarDato(Tabla, txt._columna);
                    else
                    {
                        string rtdo = BuscarDato(Tabla, txt._columna);
                        if (rtdo != "")
                            txt.Text = rtdo;
                    }
                }
                if (TipoControl == "ComboBox01")
                {
                    ComboBox01 cmb = item as ComboBox01;
                    if (cmb._Validable == true)
                        cmb.SelectedValue = Int64.Parse(BuscarDato(Tabla, cmb._columna));
                    //Añadir los cmb nulos
                    else
                    {
                        string rtdo = BuscarDato(Tabla, cmb._columna);
                        if (rtdo != "")
                            cmb.SelectedValue = Int64.Parse(rtdo);
                    }
                }
                if (TipoControl == "CheckBox01")
                {
                    CheckBox01 ckb = item as CheckBox01;
                    if (BuscarDato(Tabla, ckb._columna) == "True")
                        ckb.Checked = true;
                }
            }
        }
        public string BuscarDato(DataTable Tabla, String Columna)
        {
            for (int i = 0; i < Tabla.Columns.Count; i++)
            {
                if (Tabla.Columns[i].Caption.ToUpper() == Columna.Trim().ToUpper())
                {
                    return Tabla.Rows[0][i].ToString();
                }
            }
            return "";
        }
    }
}
