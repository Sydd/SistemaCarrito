using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace DAO
{
    public class listaCategoria : Idao<Categoria>
    {
        static listaCategoria cate;
        List<Categoria> categorias = new List<Categoria>();
       
        private listaCategoria()
        {

        }
        static public  listaCategoria singleton()
        {
            if (cate == null)
            {
                cate = new listaCategoria();
            }
            return cate;
        }
        public Categoria BuscarporNombre(string _nombre)
        {
            Categoria x = null;
            foreach (Categoria i in categorias)
            {
                if (i.Nombre == _nombre)
                    x = i;
            }
            return x;
        }
        public Categoria BuscarporID(int x)
        {
            Categoria i = null;
            foreach (Categoria a in categorias)
            {
                if (a.Id == x)
                    i = a;
            }
            return i;
        }

        public  List<Categoria> GetList()
        {
            return categorias;
        }
        public void Modificar(Categoria aux)
        {
            foreach (Categoria a in categorias)
            {
                if (a.Id == aux.Id)
                {
                    a.Descripcion = aux.Descripcion;
                    a.Nombre = aux.Nombre;
                }
            }
        }
        public void Agregar(Categoria aux)
        {
            categorias.Add(aux);
        }
        public void Borrar(Categoria aux)
        {
            categorias.Remove(aux);
        }
        public int ultimo()
        {
            int i = 0;
            if (categorias.Count == 0)
                return i - 1;
            else
                i = categorias[categorias.Count-1].Id;
            return i;
        }
    }
}
