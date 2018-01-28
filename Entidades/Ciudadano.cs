using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciudadano
    {
        public int id_ciudadano { get; set; }
        public string ci { get; set; }
        public string pasaporte { get; set; }
        public DateTime fecha_na { get; set; }
        public string nivel_instruccion { get; set; }
        public string genero { get; set; }
    }
}
