﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Farmacia_Matute.Clases
{
    class EstructuraComboBox
    {
        public string Display { get; set; }
        public string Value { get; set; }
        public string Sql { get; set; }
        public DataTable Tabla { get; set; }
    }
}
