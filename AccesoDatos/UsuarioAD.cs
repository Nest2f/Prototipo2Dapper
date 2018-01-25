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
            bd.CrearComandoStrSql("insert usuario (nombre, apellidos, ID)" +
            " values(@nombre, @apellidos, @ID) SELECT SCOPE_IDENTITY()");

            bd.AsignarParametro("@nombres", item.nombre);
            bd.AsignarParametro("@apellidos", item.apellidos);
            bd.AsignarParametroInt("@ID", item.ID);
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
            bd.CrearComandoStrSql(" update usuario set nombres = @nombres, spellidos = @Apellidos, ID = @ID where ID=" + item.ID + "");
            bd.AsignarParametro("@nombres", item.nombre);
            bd.AsignarParametro("@Apellidos", item.apellidos);
            bd.AsignarParametroInt("@ID", item.ID);
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
            bd.CrearComandoStrSql("select  * from usuario  where apellidos ='" + usuario.apellidos + "' AND nombre='" + usuario.nombre + "'");
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
                item.nombre = Convert.ToString(Datos.GetValue(0));
                item.apellidos = Convert.ToString(Datos.GetValue(1));
                item.ID = Convert.ToInt32(Datos.GetValue(2));
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
