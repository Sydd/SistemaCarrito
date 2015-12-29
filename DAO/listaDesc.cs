using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace DAO
{
    //Clase estatica, con singleton. Proximamente con DAO.
    //Esta clase contiene una lista de objetos Descuento. (lDesc)
    //Ademas de eso contiene los metodos basicos de agregar.
    
    public class listaDesc : Idao<Descuentos>
    {
        static listaDesc desc;
        List<Descuentos> lDesc = new List<Descuentos>();


        public void listDesc() { }
        
        static public listaDesc singleton()
        {
            if (desc == null)
                desc = new listaDesc();
            return desc;
        }
        public void Modificar(Descuentos _aborrar)
        {
           
        }
        public void Agregar(Descuentos aux)
        {
            lDesc.Add(aux);
        }
        public void Borrar(Descuentos aux)
        {
            lDesc.Remove(aux);
        }
        public List<Descuentos> GetList()
        {
             return desc.lDesc;
        }
        public Descuentos BuscarporID(int ID)
        {
            Descuentos a = null;
            foreach (Descuentos i in lDesc)
            {
                if (i.Id == ID)
                    a = i;
            }
            return a;
        }
        public Descuentos BuscarporNombre(string nombre)
        {
            return null;
        }

        public int ultimo()
        {
            int i = 0;
            if (lDesc.Count == 0)
                return i - 1;
            else
                i = lDesc[lDesc.Count - 1].Id;
            return i;
        }
    }
}
