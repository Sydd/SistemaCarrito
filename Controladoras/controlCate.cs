using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;
namespace Controladoras
{
    public class controlCate
    {
        listaCategoria listarcate = listaCategoria.singleton();
        public void nuevaCategoria(string _nombre, string _desc)
        {
            //crea una categoria nueva. Para el ID, 
            Categoria aux = new Categoria(_nombre,_desc,listarcate.ultimo() + 1);
            listarcate.Agregar(aux);
        }
        public void borrarcategoria(string nombre)
        {
            //borra una categoria...
            bool elimino = false;
            Categoria Auxi = null;
            foreach( Categoria aux in listarcate.GetList())
            {
                if (aux.Nombre == nombre)
                {
                    Auxi = aux;
                    elimino = true;
                }

            }
            if (elimino)
                listarcate.Borrar(Auxi); 
            else
                throw new Exception(" Error: La categoria no existe");
        }
        public List<Categoria> listarcategoria()
        {
            return listarcate.GetList();
        }
        public void borrarporID(int ID)
        {
            bool elimino = false;
            Categoria aux = null;
            foreach (Categoria a in listarcate.GetList())
            {
                if (a.Id ==ID)
                {
                    aux = a;
                    elimino = true;
                }
            }
            if (elimino)
                listarcate.Borrar(aux);
            else
                throw new Exception(" Error: La categoria no existe");
        }
        /* INUTILIZADA ACTUALMENTE, DEJADA POR LAS DUDAS.
        public string getdescripcion(int index)
        {
            int x=0;
            string aux="";
            bool existe = false;
            //Busca categorias por el indice, si coinciden carga aux con la descripcion;
            //Si no, tira error.
            foreach (Categoria auxi in listarcate.GetList())
            {
                if (x == index)
                {
                    aux = auxi.Descripcion;
                    //SOLO MODO TESTEO; BORRAR LUEGO---------
                    aux += " ID: " + auxi.Id.ToString();
                    //BORRAR
                    existe = true;
                }
                x++;
            }
            if (!existe)
                throw new Exception("Error: Index no encontrado");
            return aux;
        }
        */

        public void editarcategoria(int ID, string _nombre, string _descripcion)
        {
             bool existe = false;
            //Busca las categorias por el index.
            foreach (Categoria aux in listarcate.GetList())
            {
                if (aux.Id == ID)
                {
                    Categoria modificada = new Categoria(_nombre, _descripcion, ID);
                    listarcate.Modificar(modificada);
                    existe = true;
                }
            }
            if (!existe)
                throw new Exception("Error: No se encontro la categoria");
        }
        public List<string> listarcategoriaSTRING()
        {
            List<string> hue = new List<string>();
            foreach (Categoria a in listarcate.GetList())
                hue.Add(a.Nombre);
            return hue;
        }
        public Categoria buscarporstring(string _Nombre)
        {
            Categoria a = listarcate.BuscarporNombre(_Nombre);
            if ( a != null)
                return a;
            else
                throw new Exception("ERROR EN METODO controlcate.BUSCARPORSTRING: \n Categoria no encontrada !!");
        }
    }

}
