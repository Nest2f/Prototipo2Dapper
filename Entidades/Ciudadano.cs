using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciudadano
    {
        public int id { get; set; }
        public string ci { get; set; }
        public string pasaporte { get; set; }
        public DateTime fecha_nac { get; set; }
        public int nivel_instruccion { get; set; }
        public int genero { get; set; }
    }
}
