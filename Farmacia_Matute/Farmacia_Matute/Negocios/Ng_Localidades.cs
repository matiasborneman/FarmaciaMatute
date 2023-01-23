using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia_Matute.Clases;

namespace Farmacia_Matute.Negocios
{
    class Ng_Localidades
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "Nombre";
            ec.Value = "Id_Localidad";
            ec.Sql = "SELECT * FROM Localidad";
            ec.Tabla = _BD.Consulta(ec.Sql);
            return ec;
        }
    }
}
