using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia_Matute.Clases;

namespace Farmacia_Matute.Negocios
{
    class Ng_TiposDoc
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "Descripcion";
            ec.Value = "Id_Tipo_Doc";
            ec.Sql = "SELECT * FROM Tipo_Documento";
            ec.Tabla = _BD.Consulta(ec.Sql);
            return ec;
        }
    }
}
