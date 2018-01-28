using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OpcionTipoPregunta
    {
        public int id_OTPregunta { get; set; }
        public int id_TipoPregunta { get; set; }
        public string opcion { get; set; }
        public float valor { get; set; }
    }
}
