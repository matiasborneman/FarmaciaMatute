using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Farmacia_Matute.Clases
{
    class Be_BaseDatos
    {
        public enum EstadoAccionBD { correcto, error };
        public enum TipoConexion { simple, transaccional };
        public enum EstadoTransaccion { correcta, error };

        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction Transaccion;

        public TipoConexion ControlConexion { get; set; } = TipoConexion.simple;
        public EstadoTransaccion ControlTransaccion { get; set; } = EstadoTransaccion.correcta;
        string Cadena_conexion = "Data Source=MATIU-COMPAQ\\SQLEXPRESS;Initial Catalog=_FARMACIA_MATUTE_BD;Integrated Security=True";

        public string FechaHora()
        {
            string sql = "select convert (char(10),getdate(),103)+' '+convert(char(5), getdate(),108)";
            DataTable tabla = new DataTable();
            tabla = Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }
        public void IniciarTransaccion()
        {
            ControlConexion = TipoConexion.transaccional;
            ControlTransaccion = EstadoTransaccion.correcta;
        }
        public EstadoTransaccion CerrarTransaccion()
        {
            if (ControlConexion == TipoConexion.transaccional)
            {
                if (ControlTransaccion == EstadoTransaccion.correcta)
                {
                    // terminar por commit
                    Transaccion.Commit();
                }
                else
                {
                    // terminar por rollback
                    Transaccion.Rollback();
                }
                ControlConexion = TipoConexion.simple;
                Desconectar();
            }
            return ControlTransaccion;
        }

        private void Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = Cadena_conexion;
                Conexion.Open();
                Cmd.Connection = Conexion;
                Cmd.CommandType = System.Data.CommandType.Text;
                if (ControlConexion == TipoConexion.transaccional)
                {
                    Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    Cmd.Transaction = Transaccion;
                }
            }
        }

        private void Desconectar()
        {
            if (ControlConexion == TipoConexion.simple)
            {
                Conexion.Close();
            }
        }
        public DataTable Consulta(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                + "En el comando:" + "\n"
                                + sql + "\n"
                                + "El mensaje es:" + "\n"
                                + e.Message);
            }
            Desconectar();
            return tabla;
        }
        private string EjecutarNoSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                + "En el comando:" + "\n"
                                + sql + "\n"
                                + "El mensaje es:" + "\n"
                                + e.Message);
            }

            if (sql.ToUpper().IndexOf("INSERT") >= 0)
            {
                DataTable tabla = new DataTable();
                Cmd.CommandText = "SELECT @@Identity";
                try
                {
                    tabla.Load(Cmd.ExecuteReader());
                }
                catch (Exception e)
                {
                    ControlTransaccion = EstadoTransaccion.error;
                    MessageBox.Show("Error con la Base de Datos" + "\n"
                                    + "En el comando:" + "\n"
                                    + sql + "\n"
                                    + "El mensaje es:" + "\n"
                                    + e.Message);

                }
                Desconectar();
                return tabla.Rows[0][0].ToString();
            }
            else
            {
                Desconectar();
                return "";
            }
        }

        public string Insertar(string sql)
        {
            return EjecutarNoSelect(sql);
        }
        public void Modificar(string sql)
        {
            EjecutarNoSelect(sql);
        }
        public void Borrar(string sql)
        {
            EjecutarNoSelect(sql);
        }
        public string Fecha()
        {
            string sql = "select convert (char(10), getdate(),103)";
            DataTable tabla = new DataTable();
            tabla = Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }
        public string InsertarAutomatizado(string NombreTabla, Control.ControlCollection controles)
        {
            //INSERT INTO Users (campo1, campo2,. . . campoN) VALUES (dato1, datos2, . . . datoN)
            string sqlInsertar = "INSERT INTO " + NombreTabla.Trim() + " (";
            string sqldatos = " VALUES (";
            DataTable Estructura = new DataTable();
            Estructura = EstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                string ValorCampo = BuscarValorCampo(Estructura.Columns[i].Caption, NombreTabla, controles);
                if (ValorCampo != "")
                {
                    sqlInsertar += ", " + Estructura.Columns[i].Caption;
                    sqldatos += ", " + FormatearDato(ValorCampo, Estructura.Columns[i].DataType.Name);
                }
            }
            sqlInsertar = sqlInsertar + ")" + sqldatos + ")";
            sqlInsertar = sqlInsertar.Replace("(,", "(");
            MessageBox.Show(sqlInsertar);
            return Insertar(sqlInsertar);
        }
        public string FormatearDato(string dato, string formato)
        {
            switch (formato)
            {
                case "String":
                    return "'" + dato + "'";
                case "Date":
                case "DateTime":
                    return "convert(date,'" + dato + "', 103)";
                // dd/mm/yyyyy
                default:
                    return dato;
            }
        }
        private string BuscarValorCampo(string campo, string NombreTabla, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Pp_nombre_campo is null)
                        continue;

                    if (((TextBox01)item).Pp_nombre_tabla.IndexOf(NombreTabla) != -1
                        && ((TextBox01)item).Pp_nombre_campo == campo)
                    {
                        return ((TextBox01)item).Text;
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).Pp_nombre_campo is null)
                        continue;

                    if (((ComboBox01)item).Pp_nombre_tabla.IndexOf(NombreTabla) != -1
                        && (((ComboBox01)item).Pp_nombre_campo == campo))
                    {
                        return ((ComboBox01)item).SelectedValue.ToString();
                    }
                }
            }
            return "";
        }
        public void ModificarAutomatizado(string NombreTabla, string restriccion, Control.ControlCollection controles)
        {
            //UPDATE Users SET campo1 = dato1 , campo2 = datos2, . . . campoN = datoN WHERE id_usuario = 1
            string sqlUpdate = "UPDATE " + NombreTabla.Trim() + " SET ";

            DataTable Estructura = new DataTable();
            Estructura = EstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                string ValorCampo = BuscarValorCampo(Estructura.Columns[i].Caption, NombreTabla, controles);
                if (ValorCampo != "")
                {
                    sqlUpdate += ", " + Estructura.Columns[i].Caption + " = "
                        + FormatearDato(ValorCampo, Estructura.Columns[i].DataType.Name);
                }
            }
            sqlUpdate = sqlUpdate + " WHERE " + restriccion;
            sqlUpdate = sqlUpdate.Replace("SET ,", "SET ");
            MessageBox.Show(sqlUpdate);
            Modificar(sqlUpdate);
        }
        private DataTable EstructuraTabla(string NombreTabla)
        {
            string sql = "SELECT TOP 1 * FROM " + NombreTabla.Trim();
            DataTable tabla = new DataTable();
            tabla = this.Consulta(sql);
            return tabla;
        }
    } 
}
