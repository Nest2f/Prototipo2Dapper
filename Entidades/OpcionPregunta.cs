using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OpcionPregunta
    {
        public int id_OpcionPregunta { get; set; }
        public int id_Pregunta { get; set; }
        public string opcion { get; set; }
        public float valor { get; set; }
        public int tipo { get; set; }
    }
}
