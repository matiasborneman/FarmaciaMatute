using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia_Matute.Clases;

namespace Farmacia_Matute.Negocios
{
    class Ng_Laboratorios
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "Razon_Social";
            ec.Value = "CUIT_Laboratorio";
            ec.Sql = "SELECT * FROM Laboratorios";
            ec.Tabla = _BD.Consulta(ec.Sql);
            return ec;
        }

        //*****
        public DataTable Buscar_Est_todos_Lab()
        {
            string sql = "SELECT l.Razon_Social as 'Laboratorio', COUNT (m.Id_Medicamento) as 'Total'" +
                "FROM Laboratorios l JOIN Medicamentos m ON l.CUIT_Laboratorio = m.CUIT_Laboratorio " +
                "Group By l.CUIT_Laboratorio, l.Razon_Social ";

            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        //*****
        public DataTable Buscar_Est_X_Lab(string Lab)
        {
            string sql = "SELECT l.Razon_Social as 'Laboratorio', COUNT (m.Id_Medicamento) as 'Total'" +
                "FROM Laboratorios l JOIN Medicamentos m ON l.CUIT_Laboratorio = m.CUIT_Laboratorio " +
                "WHERE l.CUIT_Laboratorio = '" + Lab.Trim() + "' Group By l.CUIT_Laboratorio, l.Razon_Social" ;

            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        
        
        
        
        
        
        
        
        
        
        }
    }
}
