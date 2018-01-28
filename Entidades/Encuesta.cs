using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Encuesta
    {
        public int id_encuesta { get; set; }
        public DateTime fecha_encuesta { get; set; }
        public int id_ciudadano { get; set; }
        public int id_cuestionario { get; set; }
        public int id_usuario { get; set; }
        public int estado { get; set; }
    }
}
