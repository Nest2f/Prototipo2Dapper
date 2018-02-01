using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
    public class CategoriaLN
    {
        public void Insertar(Categoria categoria)
        {
            CategoriaAD acceso = new CategoriaAD();
            acceso.InsertCategorie(categoria);
        }
        public void Update(Categoria categoria)
        {
            CategoriaAD acceso = new CategoriaAD();
            acceso.UpdateCategorie(categoria);
        }
        public List<Categoria> Mostrar()
        {
            CategoriaAD acceso = new CategoriaAD();
            return acceso.MostrarCategoria();
        }
        public Categoria CategoriaID(Categoria categoria)
        {
            CategoriaAD acceso = new CategoriaAD();
            return acceso.CategoriaID(categoria);
        }
    }
}
