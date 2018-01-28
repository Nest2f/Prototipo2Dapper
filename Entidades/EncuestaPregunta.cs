using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EncuestaPregunta
    {
        public int id_encuesta { get; set; }
        public int id_pregunta { get; set; }
        public string respuesta { get; set; }
        public float valorrespuesta { get; set; }
        public string respuestapregunta { get; set; }
    }
}
