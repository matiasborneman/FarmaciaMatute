using Farmacia_Matute.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Matute.Negocios
{
    class Ng_ControlStock
    {
        public enum Respuesta { validacion_correcta, validacion_incorrecta };
        Be_BaseDatos _BD = new Be_BaseDatos();

        public string Insertar(string cuitFarmacia, string cuitLab, string idmedicamento, string cantStock, string cantMin, string cantMax)
        {
            string sqlInsert = @"INSERT INTO Stock( CUIT_Farmacia,CUIT_Laboratorio,Id_Medicamento,Cant_en_Stock,Can_min_Stock,Cant_max_Stock) VALUES (";
            sqlInsert += cuitFarmacia;
            sqlInsert += "," + cuitLab;
            sqlInsert+= ", " + _BD.FormatearDato(idmedicamento, "int16");
            sqlInsert += "," + _BD.FormatearDato(cantStock, "int16");
            sqlInsert += "," + _BD.FormatearDato(cantMin, "int16");
            sqlInsert += "," + _BD.FormatearDato(cantMax, "int16")+ " )";

            //MessageBox.Show(sqlInsert);

            return _BD.Insertar(sqlInsert);
        }

        public void Modificar(string cuitFarmacia, string cuitLab, string idmedicamento, string cantStock, string cantMin, string cantMax )
        {
            string SqlUpdate = "UPDATE Stock SET ";
            SqlUpdate += "Cant_en_Stock = " + cantStock;
            SqlUpdate += ", " + " Can_min_Stock = " + cantMin;
            SqlUpdate += ", " + "Cant_max_Stock = " + cantMax;
            SqlUpdate += " WHERE  CUIT_Farmacia = " + cuitFarmacia + " AND CUIT_Laboratorio = " + cuitLab + "AND Id_Medicamento = " + _BD.FormatearDato(idmedicamento,"int16");

            //MessageBox.Show(SqlUpdate);

            _BD.Modificar(SqlUpdate);
        }

        public DataTable BuscarMedicamento(string cuitFarmacia, string cuitLab, string idmedicamento)
        {
            string sql = "SELECT * FROM Stock WHERE  CUIT_Farmacia = " +cuitFarmacia
                        + " AND CUIT_Laboratorio = " +cuitLab+ "AND Id_Medicamento = " + int.Parse(idmedicamento);
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public Boolean MedicamentoEsta(string cuitFarmacia, string cuitLab, string idmedicamento)
        {
            string sql = "SELECT * FROM Stock WHERE  CUIT_Farmacia = " + cuitFarmacia
                        + " AND CUIT_Laboratorio = " + cuitLab + "AND Id_Medicamento = " + int.Parse(idmedicamento);
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            if (tabla.Rows.Count == 1)
                return true;
            return false;
        }
    }
}
