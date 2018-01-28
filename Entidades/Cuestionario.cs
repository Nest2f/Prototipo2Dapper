using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuestionario
    {
        public int id_cuest { get; set; }
        public string nombre_cuest { get; set; }
        public string cabecera { get; set; }
        public string pui { get; set; }
        public string ruta_loco { get; set; }
        public int int_tipocuest { get; set; }
        public bool estado { get; set; }
        public int fcreado { get; set; }
        public int fmodificado { get; set; }
        public int creadopor { get; set; }
        public int modificadopor { get; set; }
    }
}
