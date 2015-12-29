using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace DAO
{
    public class listaProducto : Idao<Producto>
    {
        static listaProducto pro;
        List<Producto> lPro = new List<Producto>();
        //Metodo singleton;
        static public listaProducto singleton()
        {
            if (pro == null)
                pro = new listaProducto();
            return pro;
        }
        //3 metodos basicos.
        public void Agregar(Producto data)
        {
            lPro.Add(data);
        }
        public void Borrar(Producto data)
        {
            lPro.Remove(data);
        }

        public void Modificar(Producto data_amodificar)
        {
            foreach (Producto a in lPro)
                if (a.Id == data_amodificar.Id)
                {
                    a.Nombre = data_amodificar.Nombre;
                    a.PrecioReal = data_amodificar.PrecioReal;
                }
        }         
        //Retorno de la lista;
        public List<Producto> GetList()
        {
            return lPro; 
        }
        //2 Metodos de busca; en caso de no encontrar retornan NULL
        public Producto BuscarporID(int ID)
        {
            foreach (Producto a in lPro)
                if (ID == a.Id) return a;
            return null;
        }
        public Producto BuscarporNombre(string nombre)
        {
            foreach (Producto a in lPro)
                if (nombre == a.Nombre) return a;
            return null;
        }
    }
}
