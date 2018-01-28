using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class UsuarioAD
    {
        public int InsertUser(Usuario item)

        {
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            //SELECT SCOPE_IDENTITY() retorna el id que fue insertado
            bd.CrearComandoStrSql("insert usuario (id, nombrecompleto, email, usuario, clave, activo, rol)" +
            " values(@nombres, @usuario, @clave, @ID) SELECT SCOPE_IDENTITY()");
            bd.AsignarParametroInt("@ID", item.ID);
            bd.AsignarParametro("@nombres", item.nombrecompleto);
            bd.AsignarParametro("@email", item.email);
            bd.AsignarParametro("@usuario", item.usuario);
            bd.AsignarParametro("@clave", item.clave);
            bd.AsignarParametro("@activo", item.activo);
            //bd.AsignarParametro("@foto", item.foto);
            bd.AsignarParametro("@rol", item.rol);



            //el id que fue insertado
            int id = bd.EjecutarComandoSqlReturnID();
            bd.Desconectar();
            return id;
        }

        public int UpdateUser(Usuario item)
        {
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            //SELECT SCOPE_IDENTITY() retorna el id que fue insertado
            bd.CrearComandoStrSql(" update usuario set nombres = @nombrecompleto, email = @email, email = @email, usuario = @usuario, clave = @clave, activo = @activo, rol = @rol where ID=" + item.ID + "");
            bd.AsignarParametroInt("@id", item.ID);
            bd.AsignarParametro("@nombres", item.nombrecompleto);
            bd.AsignarParametro("@email", item.email);
            bd.AsignarParametro("@usuario", item.usuario);
            bd.AsignarParametro("@clave", item.clave);
            bd.AsignarParametro("@activo", item.activo);
            bd.AsignarParametro("@rol", item.rol);
            //el id que fue insertado

            int id = bd.EjecutarComandoSqlReturnID();
            bd.Desconectar();
            return id;
        }

        public List<Usuario> MostrarUser()
        {
            List<Usuario> list = new List<Usuario>();
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            bd.CrearComandoStrSql("select * from usuario");
            list = Mapear(bd.EjecutarConsulta());
            bd.Desconectar();
            return list;
        }
        public Usuario Logear(Usuario usuario)
        {

            Usuario user = null;
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            bd.CrearComandoStrSql("select  * from usuario  where usuario ='" + usuario.usuario + "' AND clave='" + usuario.clave + "'");
            foreach (Usuario item in Mapear(bd.EjecutarConsulta()))
            {
                user = item;

            }
            bd.Desconectar();
            return user;

        }

        public List<Usuario> Mapear(System.Data.Common.DbDataReader Datos)
        {
            List<Usuario> list = new List<Usuario>();
            while (Datos.Read())
            {
                Usuario item = new Usuario();
                item.ID = Convert.ToInt32(Datos.GetValue(0));
                item.usuario = Convert.ToString(Datos.GetValue(3));
                item.clave = Convert.ToString(Datos.GetValue(4));
                
                list.Add(item);
            }
            return list;
        }
        public Usuario UsuariosID(Usuario usuarios)
        {
            Usuario grup = null;
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            bd.CrearComandoStrSql("Select * from usuario");
            bd.AsignarParametroInt("@id_usuario",usuarios.ID);
            foreach (Usuario item in Mapear(bd.EjecutarConsulta()))
            {
                grup = item;

            }
            bd.Desconectar();
            return grup;
        }
    }      
 
}
