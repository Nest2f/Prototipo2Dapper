using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int ID { get; set; }
        public string nombrecompleto { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public bool activo { get; set; }
        //public string foto { get; set; }
        public int rol { get; set; }
    }
}
