using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class DataController
    {
        // Cargamos los Combobox aquí
        public static DataTable LoadNames() 
        {
            return DataModelo.LoadNames();
        }
    }
}
