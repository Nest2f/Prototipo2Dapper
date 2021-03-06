﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class CategoriaAD
    {
        public int InsertCat(Categoria item)

        {
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            //SELECT SCOPE_IDENTITY() retorna el id que fue insertado
            bd.CrearComandoStrSql("insert categoria (id, descripcion, id_padre)" +
            " values(@id_padre, @descripcion @id) SELECT SCOPE_IDENTITY()");
            bd.AsignarParametroInt("@id", item.id);
            bd.AsignarParametro("@descripcion", item.descripcion);
            bd.AsignarParametroInt("@id_padre", item.id_padre);

            //el id que fue insertado
            int id = bd.EjecutarComandoSqlReturnID();
            bd.Desconectar();
            return id;
        }

        public int UpdateCat(Categoria item)
        {
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            //SELECT SCOPE_IDENTITY() retorna el id que fue insertado
            bd.CrearComandoStrSql(" update categoria set descripcion = @descripcion, id_padre = @id_padre where id=" + item.id + "");
            bd.AsignarParametroInt("@id", item.id);
            bd.AsignarParametro("@descripcion", item.descripcion);
            bd.AsignarParametroInt("@id_padre", item.id_padre);
            //el id que fue insertado

            int id = bd.EjecutarComandoSqlReturnID();
            bd.Desconectar();
            return id;
        }

        public List<Categoria> MostrarCat()
        {
            List<Categoria> list = new List<Categoria>();
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            bd.CrearComandoStrSql("select * from categoria");
            list = Mapear(bd.EjecutarConsulta());
            bd.Desconectar();
            return list;
        }

        public List<Categoria> Mapear(System.Data.Common.DbDataReader Datos)
        {
            List<Categoria> list = new List<Categoria>();
            while (Datos.Read())
            {
                Categoria item = new Categoria();
                item.id = Convert.ToInt32(Datos.GetValue(0));
                item.descripcion = Convert.ToString(Datos.GetValue(3));
                item.id_padre = Convert.ToInt32(Datos.GetValue(4));

                list.Add(item);
            }
            return list;
        }
        public Categoria CategoriasID(Categoria categoria)
        {
            Categoria grup = null;
            BaseDatos bd = new BaseDatos();
            bd.Conectar();
            bd.CrearComandoStrSql("Select * from categoria");
            bd.AsignarParametroInt("@id", categoria.id);
            foreach (Categoria item in Mapear(bd.EjecutarConsulta()))
            {
                grup = item;

            }
            bd.Desconectar();
            return grup;
        }
    }
}
