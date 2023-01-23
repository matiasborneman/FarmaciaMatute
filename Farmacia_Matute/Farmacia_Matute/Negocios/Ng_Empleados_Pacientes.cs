using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Farmacia_Matute;
using Farmacia_Matute.Clases;
using Farmacia_Matute.Negocios.EstructurasNegocios;

namespace Farmacia_Matute.Negocios
{
    class Ng_Empleados_Pacientes
    {
        //public enum accionBD { correcta, error}
        public enum Respuesta { validacion_correcta, validacion_incorrecta };
        Be_BaseDatos _BD = new Be_BaseDatos();

        public Respuesta Validar_Empleado(string tipo, string nro)
        {
            //    SELECT * FROM users WHERE n_usuario = 'Luis' AND password = '123'
            string sql = "";
            sql = "SELECT * FROM Empleados_Pacientes WHERE Id_Tipo_Doc = '" + tipo + "' AND Nro_Doc= '" + int.Parse(nro) + "');";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                //decir que no existe el Empleado
                return Respuesta.validacion_incorrecta;
            }
            else
            {
                //se encontro el empleado  y se lo validó 
                return Respuesta.validacion_correcta;
            }
        }
        public DataTable Todos_los_Empleados()
        {
            string sql = "SELECT * FROM Empleados_Pacientes WHERE Id_Rol !=6 ";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        // muestra todos los empleados menos los que son paciente (o sea id_rol=6)
        public DataTable buscar_Empleado_Paciente(string tipo, string nro,bool rol)
        {
            string sql = "SELECT * FROM Empleado_Paciente WHERE Id_Tipo_Doc = " + tipo.Trim()
                        + " AND Nro_Doc = " + int.Parse(nro);
            if(rol)
            {
                sql += " AND Id_Rol= 6";
            }
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }


        public DataTable Buscar_paciente_ob_soc(string tipod, string nrod)
        {

            string Sql = "SELECT TP.descripcion, EP.Nro_Doc, EP.Apellido, EP.Nombre, OS.descripcion as 'ob_Soc'" +
            "FROM Empleado_Paciente EP JOIN Tipo_Documento TP ON EP.Id_Tipo_Doc = TP.Id_Tipo_Doc " +
            "JOIN Obra_Social OS ON EP.Id_Ob_Soc = OS.id_ob_soc " +
            "JOIN Rol R ON EP.Id_Rol = R.Id_Rol WHERE r.Id_Rol = 6 AND TP.Id_Tipo_Doc = " + tipod.Trim() + " AND EP.Nro_Doc = " + nrod.Trim();

                DataTable tabla = new DataTable();
                tabla = _BD.Consulta(Sql);
                return tabla;
        }
        public DataTable Buscar_ob_soc(string nro3)
        {
            string Sql = "SELECT TP.descripcion, EP.Nro_Doc, EP.Apellido, EP.Nombre, OS.descripcion as 'ob_Soc'" +
            "FROM Empleado_Paciente EP JOIN Tipo_Documento TP ON EP.Id_Tipo_Doc = TP.Id_Tipo_Doc " +
            "JOIN Obra_Social OS ON EP.Id_Ob_Soc = OS.id_ob_soc " +
            "JOIN Rol R ON EP.Id_Rol = R.Id_Rol " +
            "WHERE r.Id_Rol = 6 AND OS.id_ob_soc = " + nro3 ;

            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(Sql);
            return tabla;
        }
        public void Insertar(Control.ControlCollection controles)
        {
            _BD.InsertarAutomatizado("Empleado_Paciente", controles);
        }
        //inserta Empleados
        public string Insertar(Es_Empleado datos)
        {
            string sqlInsert = @"INSERT INTO Empleado_Paciente( Id_Tipo_Doc, Nro_Doc, Apellido, Nombre, Id_Rol, Fecha_Nac, Id_Ob_Soc, Calle, Calle_Nro,Id_Barrio, Id_User) VALUES (";

            sqlInsert += "" + _BD.FormatearDato(datos.id_tipo_doc, "Int16");
            sqlInsert += "," + _BD.FormatearDato(datos.nro_doc, "Int16");
            sqlInsert += "," + _BD.FormatearDato(datos.apellido, "String");
            sqlInsert += "," + _BD.FormatearDato(datos.nombre, "String");
            sqlInsert += ", " + _BD.FormatearDato(datos.id_rol, "Int16");
            sqlInsert += "," + _BD.FormatearDato(datos.fecha_nac, "DateTime");
            sqlInsert += "," + _BD.FormatearDato(datos.id_ob_social, "Int16");
            sqlInsert += "," + _BD.FormatearDato(datos.calle, "String");
            sqlInsert += ", " + _BD.FormatearDato(datos.calle_nro, "Int16");
            sqlInsert += "," + _BD.FormatearDato(datos.id_barrio, "Int16");
            sqlInsert += ", null )";

            //MessageBox.Show(sqlInsert);

            return _BD.Insertar(sqlInsert);
        }
        //inserta paciente
        public string Insertar(Es_Paciente datos)
        {
            string sqlInsert = @"INSERT INTO Empleado_Paciente( Id_Tipo_Doc, Nro_Doc, Apellido, Nombre, Id_Rol, Fecha_Nac, Id_Ob_Soc, Calle, Calle_Nro,Id_Barrio, Id_User) VALUES (";

            sqlInsert += "" + _BD.FormatearDato(datos.id_tipo_doc, "Int16");
            sqlInsert += "," + _BD.FormatearDato(datos.nro_doc, "Int16");
            sqlInsert += "," + _BD.FormatearDato(datos.apellido, "String");
            sqlInsert += "," + _BD.FormatearDato(datos.nombre, "String");
            sqlInsert += ", " + _BD.FormatearDato(datos.id_rol, "Int16");
            sqlInsert += "," + _BD.FormatearDato(datos.fecha_nac, "DateTime");
            sqlInsert += "," + _BD.FormatearDato(datos.id_ob_social, "Int16");
            sqlInsert += "," + _BD.FormatearDato(datos.calle, "String");
            sqlInsert += ", " + _BD.FormatearDato(datos.calle_nro, "Int16");
            sqlInsert += "," + _BD.FormatearDato(datos.id_barrio, "Int16");
            sqlInsert += ", null )";

            //MessageBox.Show(sqlInsert);

            return _BD.Insertar(sqlInsert);
        }
        public void Modificar(string id_tipo_doc, string nro_doc, Control.ControlCollection controles)
        {
            _BD.ModificarAutomatizado("Empleado_Paciente", "Id_Tipo_Doc = " + int.Parse(id_tipo_doc) + "AND Nro_Doc = " + int.Parse(nro_doc), controles);
        }
        //modifica empleado
        public void Modificar(Es_Empleado datos)
        {
            string SqlUpdate = "UPDATE Empleado_Paciente SET ";
            SqlUpdate += " Apellido = " + _BD.FormatearDato(datos.apellido, "String");
            SqlUpdate += ", Nombre = " + _BD.FormatearDato(datos.nombre, "String");
            SqlUpdate += ", Id_Rol = " + _BD.FormatearDato(datos.id_rol, "Int16");
            SqlUpdate += ", Fecha_Nac = " + _BD.FormatearDato(datos.fecha_nac, "DateTime");
            SqlUpdate += ", Id_Ob_Soc = " + _BD.FormatearDato(datos.id_ob_social, "Int16");
            SqlUpdate += ", Calle = " + _BD.FormatearDato(datos.calle, "String");
            SqlUpdate += ", Calle_Nro = " + _BD.FormatearDato(datos.calle_nro, "Int16");
            SqlUpdate += ", Id_Barrio = " + _BD.FormatearDato(datos.id_barrio, "Int16");
            SqlUpdate += ", Id_User = null " ;
            SqlUpdate += " WHERE Id_Tipo_Doc = " + datos.id_tipo_doc + " AND Nro_Doc = " + datos.nro_doc;

            //MessageBox.Show(SqlUpdate);

            _BD.Modificar(SqlUpdate);
        }
        // modifica paciente
        public void Modificar(Es_Paciente datos)
        {
            string SqlUpdate = "UPDATE Empleado_Paciente SET ";
            SqlUpdate += " Apellido = " + _BD.FormatearDato(datos.apellido, "String");
            SqlUpdate += ", Nombre = " + _BD.FormatearDato(datos.nombre, "String");
            SqlUpdate += ", Id_Rol = " + _BD.FormatearDato(datos.id_rol, "Int16");
            SqlUpdate += ", Fecha_Nac = " + _BD.FormatearDato(datos.fecha_nac, "DateTime");
            SqlUpdate += ", Id_Ob_Soc = " + _BD.FormatearDato(datos.id_ob_social, "Int16");
            SqlUpdate += ", Calle = " + _BD.FormatearDato(datos.calle, "String");
            SqlUpdate += ", Calle_Nro = " + _BD.FormatearDato(datos.calle_nro, "Int16");
            SqlUpdate += ", Id_Barrio = " + _BD.FormatearDato(datos.id_barrio, "Int16");
            SqlUpdate += ", Id_User = null ";
            SqlUpdate += " WHERE Id_Tipo_Doc = " + datos.id_tipo_doc + " AND Nro_Doc = " + datos.nro_doc;

            //MessageBox.Show(SqlUpdate);

            _BD.Modificar(SqlUpdate);
        }
        public void Borrar(string id_tipo_doc, string nro_doc)
        {
            string sqlDelete = "DELETE FROM Empleado_Paciente WHERE Id_Tipo_Doc= " + int.Parse(id_tipo_doc) + "AND Nro_Doc = " + nro_doc;
            _BD.Borrar(sqlDelete);
        }

        public void BorrarCliente(string id_tipo_doc, string nro_doc)
        {
            string sqlDelete = "DELETE FROM Empleado_Paciente WHERE Id_Tipo_Doc= " + int.Parse(id_tipo_doc) + "AND Nro_Doc = " + nro_doc + "AND Id_Rol=6";
            _BD.Borrar(sqlDelete);
        }

        public  void BorrarUsuario(string id_tipo_doc, string nro)
        {
            string sqlUpdate = "UPDATE Empleado_Paciente SET Id_User= NULL WHERE Id_Tipo_Doc = " + int.Parse(id_tipo_doc) + " AND Nro_Doc= " + int.Parse(nro);
            _BD.Modificar(sqlUpdate);
        }
        public void ModificarUsuario(string id_tipo_doc, string nro, string user)
        {
            string sqlUpdate = "UPDATE Empleado_Paciente SET Id_User= '"+ user +"' WHERE Id_Tipo_Doc = " + int.Parse(id_tipo_doc) + " AND Nro_Doc= " + int.Parse(nro);
             _BD.Modificar(sqlUpdate);
        }
        public DataTable RecuperarUsuario(string tipo_Doc, string nro)
        {
           return _BD.Consulta("SELECT * FROM Empleado_Paciente WHERE Id_Tipo_Doc = " + int.Parse(tipo_Doc) + " AND Nro_Doc= "+ int.Parse(nro));
        }
    }
}
