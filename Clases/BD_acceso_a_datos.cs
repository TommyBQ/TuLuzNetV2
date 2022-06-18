using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLuzNet.Clases
{
    class BD_acceso_a_datos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string cadena = "Data Source = 200.69.137.167,11333; Initial Catalog = BD3K6G02_2022; User ID = BD3K6G02_2022; Password=BDG02_5467";

        //ENUMERACION PARA DISTINGUIR EL TIPO DE CONEXION QUE SE REALIZARÁ
        public enum TipoConexion { simple, transaccion }
        //ENUMERACION PARA ESTABLECER EL STATUS DE UNA CONEXION TRANSACCIONAL
        public enum TipoEstado { correcto, error, sinTransaccion }

        //VARIABLE PARA CONTROLAR EL TIPO DE CONEXION ESTABLECIDA
        TipoConexion ControlTipoConexion = TipoConexion.simple;
        //VARIABLE PARA CONTROLAR EL ESTADO DE LA TRANSACCION
        TipoEstado ControlTransaccion = TipoEstado.correcto;
        SqlTransaction transaccion;

        public void IniciarTransaccion()
        {
            ControlTipoConexion = TipoConexion.transaccion;
            ControlTransaccion = TipoEstado.correcto;
        }

        public TipoEstado FinalizarTransaccion()
        {
            // valida si la conexión es simple, al no ser una conexión transaccional
            // no se debiera haber activado esta función, por lo que se devuelve
            // un valor de correcto para finalizar la ejecución.
            if (ControlTipoConexion == TipoConexion.simple)
                return TipoEstado.sinTransaccion;
            // se valida el status del Control de Transacción. Si es correcto se termina
            // la transacción por COMMIT, en caso contrario finaliza por ROLLBACK
            if (ControlTransaccion == TipoEstado.correcto)
            {
                // termina transacción por commit
                transaccion.Commit();
            }
            else
            {
                // termina transaccion por rollback
                transaccion.Rollback();
            }
            // al finalizar la transacción se cambio es status del control de conexión a
            // conexion del tipo simple para poder desconectar 
            ControlTipoConexion = TipoConexion.simple;
            // desconecta 
            Desconectar();
            // devuelve via la función el estado con el que finalizó la transacción para
            // conocimiento de la programación donde fue invocada la transacción
            return ControlTransaccion;
        }

        public void Conectar()
        {
            // valida en estado de la conexion, inicia una conexión solo en el caso de
            // que la conexión este cerrada
            if (conexion.State == ConnectionState.Closed)
            {
                // asigna cadena de conexión
                conexion.ConnectionString = cadena;
                try
                {
                    // abre la conexión col na base de datos
                    conexion.Open();
                }
                catch (Exception e)
                {
                    // mensaje de error que se emite cuando se produjo un error en el
                    // comando de apertura de la conexión
                    MessageBox.Show("Hubo un error en la Base de Datos\n"
                    + "Con el comando: \n"
                    + "conexion.Open()" + "\n"
                    + "El error en la base de datos:\n"
                    + e.Message);
                    // cambio de estado del control de transacción
                    ControlTransaccion = TipoEstado.error;
                    return;
                }
                // asigna al comando cmd quien es la conexión sobre la que debe trabajar
                cmd.Connection = conexion;
                // establece en el comando el tipo que tendrá
                cmd.CommandType = CommandType.Text;
                // valida si la conexión actual es del tipo transaccional
                if (ControlTipoConexion == TipoConexion.transaccion)
                {
                    // crea el objeto administrador de la transacción que se
                    // genera a partir de la conexión actual abierta.
                    // IsolationLever: Especifica el comportamiento de bloqueo 
                    // de transacción para la conexión.
                    // ReadCommitted: Los bloqueos compartidos se mantienen
                    // mientras se están leyendo los datos para evitar lecturas erróneas. 
                    transaccion = conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    // también se informa al comando quien es el administrador de la
                    // transacción
                    cmd.Transaction = transaccion;
                }
            }
        }
        private void Desconectar()
        {
            // valida que tipo de conexión esta vigente. Solo se puede
            // desconectar mientra la conexión es simple
            if (ControlTipoConexion == TipoConexion.simple)
            {
                conexion.Close();
            }
        }
        public DataTable EjecutarSQL(string comando)
        {
            Conectar();
            cmd.CommandText = comando;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(cmd.ExecuteReader());

            }
            catch (Exception e)
            {
                // mensaje de error que se emite cuando se produjo un error en el
                // comando ejecutado anteriormente por cmd.ExecuteReader
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                    + "Con el comando: \n"
                    + comando + "\n"
                    + "El error en la base de datos:\n"
                    + e.Message);
                // cambia el control de trasacción por el error detectado
                ControlTransaccion = TipoEstado.error;
                Desconectar();
                return tabla;
            }
            Desconectar();
            return tabla;
        }

        public void CargarDatos(string sqlInsertar)
        {
            try
            {
                Conectar();
                cmd.CommandText = sqlInsertar;
                cmd.ExecuteNonQuery();
                Desconectar();
                MessageBox.Show("Se cargó el empleado.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public TipoEstado Insertar(string comando)
        {
            return EjecutarIns_Upd_Del(comando);
        }
        public TipoEstado Modificar(string comando)
        {
            return EjecutarIns_Upd_Del(comando);
        }
        public TipoEstado Borrar(string comando)
        {
            return EjecutarIns_Upd_Del(comando);
        }

        private TipoEstado EjecutarIns_Upd_Del(string sql)
        {
            Conectar();
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                + "Con el comando: \n"
                + sql + "\n"
                + "El error en la base de datos:\n"
                + e.Message);
                ControlTransaccion = TipoEstado.error;
                return ControlTransaccion;
            }
            Desconectar();
            ControlTransaccion = TipoEstado.correcto;
            return ControlTransaccion;
        }
    }
}
