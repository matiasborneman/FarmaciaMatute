using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia_Matute.Clases;
using Farmacia_Matute.Negocios.EstructurasNegocios;
namespace Farmacia_Matute.Negocios
{
    class Ng_Medicamentos
    {
        Be_BaseDatos _BD = new Be_BaseDatos();
        

        public EstructuraComboBox EstrCombo(String laboratorio)
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "Nombre";
            ec.Value = "Id_Medicamento";
            ec.Sql = "SELECT * FROM Medicamentos WHERE CUIT_Laboratorio= " + int.Parse(laboratorio);
            ec.Tabla = _BD.Consulta(ec.Sql);
            return ec;
        }
        public string Insertar(string cuitLab, string idmedicamento, string nombre, string precio, string fecha)
        {
            string sqlInsert = @"INSERT INTO Medicamentos( CUIT_Laboratorio,Id_Medicamento, Nombre,Precio_Lista,Fecha_Alta) VALUES (";
            sqlInsert += cuitLab;
            sqlInsert += ", " + _BD.FormatearDato(idmedicamento, "int16");
            sqlInsert += ", '" + nombre;
            sqlInsert += "'," + _BD.FormatearDato(precio, "int16");
            sqlInsert += "," + _BD.FormatearDato(fecha, "Date") + " )";

            //MessageBox.Show(sqlInsert);

            return _BD.Insertar(sqlInsert);
        }

        public void Modificar(string cuitLab, string idmedicamento, string nombre, string precio, string fecha)
        {
            string SqlUpdate = "UPDATE Medicamentos SET ";
            SqlUpdate += "Nombre= '" + nombre;
            SqlUpdate += "', " + "Precio_Lista  = " + _BD.FormatearDato(precio, "int16");
            SqlUpdate += ", " + "Fecha_Alta = " + _BD.FormatearDato(fecha, "Date");
            SqlUpdate += " WHERE  CUIT_Laboratorio = '" + cuitLab + "' AND Id_Medicamento = " + _BD.FormatearDato(idmedicamento, "int16");

            //MessageBox.Show(SqlUpdate);

            _BD.Modificar(SqlUpdate);
        }
        public DataTable BuscarMedicamento(string idmedicamento)
        {
            string sql = "SELECT * FROM Medicamentos WHERE Id_Medicamento = " + int.Parse(idmedicamento);
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public void Borrar(string cuitLab, string idmedicamento)
        {
            string sql = "DELETE FROM Medicamentos WHERE  CUIT_Laboratorio = " + cuitLab + " AND Id_Medicamento = " + idmedicamento;
            _BD.Borrar(sql);
        }
        public Boolean MedicamentoEsta(string cuitFarmacia, string cuitLab, string idmedicamento)
        {
            string sql = "SELECT * FROM Medicamentos WHERE  CUIT_Laboratorio = '" + cuitLab + "' AND Id_Medicamento = " + int.Parse(idmedicamento);
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            if (tabla.Rows.Count == 1)
                return true;
            return false;
        }

        public string RetornarPrecio(string id)
        {
            string sql = "SELECT * FROM Medicamentos WHERE Id_Medicamento= " + int.Parse(id);
            DataTable tabla = _BD.Consulta(sql);
            return tabla.Rows[0]["Precio_Lista"].ToString();
        }
        public int RecuperarID()
        {
            String sql = "SELECT * FROM Medicamentos";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla.Rows.Count;
        }
        public DataTable Buscar_Medicamento (string med)
        {

            string sql = "";
            sql = "SELECT M.Nombre, M.Precio_Lista, L.Razon_Social " +
                    "FROM Laboratorios L JOIN Medicamentos M ON M.Id_Medicamento = M.Id_Medicamento " +
                    "WHERE L.CUIT_Laboratorio  = M.CUIT_Laboratorio AND M.nombre like '%" + med.Trim() + "%'";
    
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Lab(string lab)
        {

            string sql = "";
            sql = "SELECT M.Nombre, M.Precio_Lista, L.Razon_Social " +
                    "FROM Laboratorios L JOIN Medicamentos M ON M.Id_Medicamento = M.Id_Medicamento " +
                    "WHERE L.CUIT_Laboratorio  = M.CUIT_Laboratorio AND L.CUIT_Laboratorio like " + lab.Trim();

            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        
    }
}
