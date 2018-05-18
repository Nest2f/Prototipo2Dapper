using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
    public class CiudadanoLN
    {
        public void Insertar(Ciudadano ciudadano)
        {
            CiudadanoAD acceso = new CiudadanoAD();
        }
        public void Update(Ciudadano ciudadano)
        {
            CiudadanoAD acceso = new CiudadanoAD();
            acceso.UpdateCiudadano(ciudadano);
        }
        public List<Ciudadano> Mostrar()
        {
            CiudadanoAD acceso = new CiudadanoAD();
            return acceso.MostrarCiu();
        }
        public Ciudadano CiudadanoID(Ciudadano ciudadano)
        {
            CiudadanoAD acceso = new CiudadanoAD();
            return acceso.CiudadanosID(ciudadano);
        }
    }
}
