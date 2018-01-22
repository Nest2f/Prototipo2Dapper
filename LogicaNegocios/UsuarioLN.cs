using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
    public class UsuarioLN
    {
        public void Insertar(Usuario usuario)
        {
            UsuarioAD acceso = new UsuarioAD();
            acceso.InsertUser(usuario);
        }
        public void Update(Usuario usuario)
        {
            UsuarioAD acceso = new UsuarioAD();
            acceso.UpdateUser(usuario);
        }
        public List<Usuario> Mostrar()
        {
            UsuarioAD acceso = new UsuarioAD();
            return acceso.MostrarUser();
        }
        public Usuario UsuarioID(Usuario usuario)
        {
            UsuarioAD acceso = new UsuarioAD();
            return acceso.UsuariosID(usuario);
        }
        public Usuario Login(Usuario usuario)
        {
            UsuarioAD acceso = new UsuarioAD();
            return acceso.Logear(usuario);
        }
    }
}
