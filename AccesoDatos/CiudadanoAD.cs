using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class CiudadanoAD
    {
        public int InsertCiudadano(Ciudadano item)

        {
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            //SELECT SCOPE_IDENTITY() retorna el id que fue insertado
            bd.CrearComandoStrSql("insert ciudadano (id, ci, pasaporte, fecha_nac, nivel_instruccion, genero)" +
            " values(@id, @ci, @pasaporte, @fecha_nac, @nivel_instruccion, @genero SELECT SCOPE_IDENTITY()");
            bd.AsignarParametroInt("@id", item.id);
            bd.AsignarParametro("@descripcion", item.ci);
            bd.AsignarParametro("@id_padre", item.pasaporte);
            bd.AsignarParametroFecha("@fecha_nac", item.fecha_nac);
            bd.AsignarParametroInt("@nivel_instruccion", item.nivel_instruccion);
            bd.AsignarParametroInt("@genero", item.genero);

            //el id que fue insertado
            int id = bd.EjecutarComandoSqlReturnID();
            bd.Desconectar();
            return id;
        }

        public int UpdateCiudadano(Ciudadano item)
        {
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            //SELECT SCOPE_IDENTITY() retorna el id que fue insertado
            bd.CrearComandoStrSql(" update ciudadano set ci = @ci, pasaporte = @pasaporte, fecha_nac = @fecha_nac, nivel_instruccion = @nivel_instruccion, genero = @genero  where id=" + item.id + "");
            bd.AsignarParametroInt("@id", item.id);
            bd.AsignarParametro("@ci", item.ci);
            bd.AsignarParametro("@pasaporte", item.pasaporte);
            bd.AsignarParametroFecha("@fecha_nac", item.fecha_nac);
            bd.AsignarParametroInt("@nivel_instruccion", item.nivel_instruccion);
            bd.AsignarParametroInt("@genero", item.genero);
            //el id que fue insertado

            int id = bd.EjecutarComandoSqlReturnID();
            bd.Desconectar();
            return id;
        }

        public List<Ciudadano> MostrarCiu()
        {
            List<Ciudadano> list = new List<Ciudadano>();
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            bd.CrearComandoStrSql("select * from ciudadano");
            list = Mapear(bd.EjecutarConsulta());
            bd.Desconectar();
            return list;
        }

        public List<Ciudadano> Mapear(System.Data.Common.DbDataReader Datos)
        {
            List<Ciudadano> list = new List<Ciudadano>();
            while (Datos.Read())
            {
                Ciudadano item = new Ciudadano();
                item.id = Convert.ToInt32(Datos.GetValue(0));
                item.ci = Convert.ToString(Datos.GetValue(1));
                item.pasaporte = Convert.ToString(Datos.GetValue(2));
                item.fecha_nac = Convert.ToDateTime(Datos.GetValue(3));
                item.nivel_instruccion = Convert.ToInt32(Datos.GetValue(4));
                item.genero = Convert.ToInt32(Datos.GetValue(5));

                list.Add(item);
            }
            return list;
        }
        public Ciudadano CiudadanosID(Ciudadano ciudadano)
        {
            Ciudadano grup = null;
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            bd.CrearComandoStrSql("Select * from ciudadano");
            bd.AsignarParametroInt("@id", ciudadano.id);
            foreach (Ciudadano item in Mapear(bd.EjecutarConsulta()))
            {
                grup = item;

            }
            bd.Desconectar();
            return grup;
        }
    }
}
