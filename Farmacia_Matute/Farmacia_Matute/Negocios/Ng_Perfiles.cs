using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia_Matute.Clases;

namespace Farmacia_Matute.Negocios
{
    class Ng_Perfiles
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "Denominacion";
            ec.Value = "Id_Rol";
            ec.Sql = "SELECT * FROM Rol";
            ec.Tabla = _BD.Consulta(ec.Sql);
            return ec;
        }
    }
}
