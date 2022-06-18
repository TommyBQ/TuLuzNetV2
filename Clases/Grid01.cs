using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLuzNet.Clases
{
    public class Grid01:DataGridView
    {
        // Nombre_cabecera, ancho, centrado;...
        public void Formatear(string formato)
        {
            string[] columnas = formato.Split(';');
            for (int i = 0; i < columnas.Length; i++)
            {
                string[] datos = columnas[i].Split(',');
                this.Columns.Add("columna" + i.ToString(), datos[0]);
                this.Columns[i].Width = int.Parse(datos[1]);
            }
        }
    }
}
