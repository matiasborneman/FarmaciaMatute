using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Farmacia_Matute.Negocios.EstructurasNegocios;
using Farmacia_Matute.Clases;

namespace Farmacia_Matute.Negocios
{
    class Ng_Users
    {
        //public enum accionBD { correcta, error}
        public enum Respuesta { validacion_correcta, validacion_incorrecta };
        Be_BaseDatos _BD = new Be_BaseDatos();

        public Respuesta Validar_usuario(string usr, string pssw)
        {
            //    SELECT * FROM users WHERE n_usuario = 'Luis' AND password = '123'
            string sql = "";
            sql = "SELECT * FROM Usuarios WHERE Id_User = '" + usr + "' AND password= '" + pssw + "'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                //decir que no existe es usuario y passw
                return Respuesta.validacion_incorrecta;
            }
            else
            {
                //se encontro el usuario y se lo validó 
                return Respuesta.validacion_correcta;
            }
        }
        public DataTable RecuperarUsuario(string id_usuario)
        {
            return _BD.Consulta("SELECT * FROM Usuarios WHERE Id_User = " + id_usuario);
        }

        public int Recuperar_Perfil(string usr)
        {
            //    SELECT * FROM users WHERE n_usuario = 'Luis' AND password = '123' y retorna el id del perfil
            string sql = "";
            sql = "SELECT * FROM Usuarios WHERE Id_User = '" + usr + "'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return int.Parse(tabla.Rows[0]["Id_Perfil"].ToString());
            }
        }
        public DataTable Todos_los_usuarios()
        {
            string sql = "SELECT * FROM Usuarios";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable buscar_usario(string nombre, string perfil)
        {
            string sql = "";
            if (nombre == "")
            {
                sql = "SELECT * FROM Usuarios WHERE Id_Perfil = " + perfil;
            }
            else
            {
                if (perfil == "0")
                {
                    // 'Luis'
                    sql = "SELECT * FROM Usuarios WHERE Id_User like '%" + nombre.Trim() + "%'";
                }
                else
                {
                    sql = "SELECT * FROM Usuarios WHERE Id_User like '%" + nombre.Trim() + "%'"
                        + " AND Id_Perfil = " + perfil;
                }
            }
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public void Insertar(Control.ControlCollection controles)
        {
            _BD.InsertarAutomatizado("Usuarios", controles);
        }
        public string Insertar(Es_Users datos)
        {
            string sqlInsert = @"INSERT INTO Usuarios( Id_User, password, Id_Perfil) VALUES (";

            sqlInsert += " '" + datos.id_usuario + "' ";
            sqlInsert += ", '" + datos.password + "'";
            sqlInsert += ", " + datos.id_perfil+ ")";

            MessageBox.Show(sqlInsert);

            return _BD.Insertar(sqlInsert);
        }
        public void Modificar(string id_usuario, Control.ControlCollection controles)
        {
            _BD.ModificarAutomatizado("Usuarios", "Id_User = " + id_usuario, controles);
        }
        public void Modificar(Es_Users datos, string usuarioAnterior)
        {
            string SqlUpdate = "UPDATE Usuarios SET ";
            SqlUpdate += "Id_User = " + _BD.FormatearDato(datos.id_usuario, "String");
            SqlUpdate += ", password = " + _BD.FormatearDato(datos.password, "String");
            SqlUpdate += ", Id_Perfil = " + _BD.FormatearDato(datos.id_perfil, "Int16");
            SqlUpdate += " WHERE Id_User = '" + usuarioAnterior+ "'";

            MessageBox.Show(SqlUpdate);

            _BD.Modificar(SqlUpdate);
        }
        public void Borrar(string id_usuario)
        {
            string sqlDelete = "DELETE FROM Usuarios WHERE Id_User= '" + id_usuario + "'";
            _BD.Borrar(sqlDelete);
        }
    }
}
