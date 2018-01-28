using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pregunta
    {
        public int id_pregunta { get; set; }
        public string nombre { get; set; }
        public string enunciado { get; set; }
        public int id_categoria { get; set; }
        public int id_tipopregunta { get; set; }
        public int fcreada { get; set; }
        public int fmodificada { get; set; }
        public int creadapor { get; set; }
        public int modificadapor { get; set; }
        public int estado { get; set; }
    }
}
