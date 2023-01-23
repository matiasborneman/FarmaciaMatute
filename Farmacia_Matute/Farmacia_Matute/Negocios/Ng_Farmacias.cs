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
    class Ng_Farmacias
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "Denominacion";
            ec.Value = "CUIT_Farmacia";
            ec.Sql = "SELECT * FROM Farmacias";
            ec.Tabla = _BD.Consulta(ec.Sql);
            return ec;
        }
    }
}
