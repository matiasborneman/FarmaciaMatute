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
    class Ng_Barrios
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public EstructuraComboBox EstrCombo(string localidad)
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "Nombre";
            ec.Value = "Id";
            ec.Sql = "SELECT * FROM Barrios WHERE Id_Localidad= "+int.Parse(localidad);
            ec.Tabla = _BD.Consulta(ec.Sql);
            return ec;
        }
        public string recuperarlocalidad(string barrio)
        {
            string sql = "SELECT * FROM Barrios WHERE id= "+ int.Parse(barrio);
            DataTable tabla = _BD.Consulta(sql);
            return tabla.Rows[0]["Id_Localidad"].ToString();
        }
    }
}
