using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia_Matute.Clases;

namespace Farmacia_Matute.Negocios
{
    class Ng_ObrasSociales
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "descripcion";
            ec.Value = "id_ob_soc";
            ec.Sql = "SELECT * FROM Obra_Social";
            ec.Tabla = _BD.Consulta(ec.Sql);
            return ec;
        }
        public String recuperarTipoCobertura(string id_cob)
        {
            string sql = "SELECT * FROM Tipo_Cobertura WHERE Id_Tipo_Cobertura= " + int.Parse(id_cob);
            DataTable tabla = _BD.Consulta(sql);
            return tabla.Rows[0]["Descripcion"].ToString();
        }
       
        //*****
        public DataTable Buscar_Est_Cli_OS()
        {
            string sql = "SELECT os.descripcion as 'Obra_Social', count(ep.Nro_Doc) as 'Total'" +
                "FROM Empleado_Paciente ep JOIN Obra_Social os ON ep.Id_Ob_Soc = os.id_ob_soc " +
                "JOIN Tipo_Documento tp ON ep.Id_Tipo_Doc = tp.Id_Tipo_Doc " +
                "WHERE ep.Id_Rol = 6 group by os.descripcion, os.id_ob_soc ";

            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        //*****
        public DataTable Buscar_Est_Cli_por_ObSoc(string obsoc)
        {
            string sql = "SELECT os.descripcion as 'Obra_Social', count (ep.Nro_Doc) as 'Total'" +
                "FROM Empleado_Paciente ep JOIN Obra_Social os ON ep.Id_Ob_Soc = os.id_ob_soc " +
                "JOIN Tipo_Documento tp ON ep.Id_Tipo_Doc = tp.Id_Tipo_Doc " +
                "WHERE ep.Id_Rol = 6 AND os.id_ob_soc = "+ obsoc.Trim() + "group by os.descripcion, os.id_ob_soc";

            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
    }
}
