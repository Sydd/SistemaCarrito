using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAO;
namespace Controladoras
{
    //Controla los descuentos;
    //Tiene un objeto DAO controldesc que se instancia mediante el metodo singleton().
    
    public class controlDesc
    {
   
        listaDesc desc = listaDesc.singleton();
        listaCategoria lCat = listaCategoria.singleton();
        public void nuevoDesc(DateTime _DESDE, DateTime _HASTA, int _PORCENTAJE, int _CATE)
        {
            List<Categoria> wihu = lCat.GetList();
            Descuentos aux = new Descuentos(_DESDE, _HASTA, _PORCENTAJE, wihu[_CATE], desc.ultimo() + 1);
            if (!comprobar(aux))
                desc.Agregar(aux);
            else
                throw new Exception("Error: Descuentos superpuestos");
        }
        public bool comprobar(Descuentos aux)
        {
            bool existe = false;
            foreach (Descuentos i in desc.GetList()) 
            {
                if (i.Categoria == aux.Categoria)
                {
                    if (aux.Desde.DayOfYear >= i.Desde.DayOfYear && i.Hasta.DayOfYear <= aux.Hasta.DayOfYear || aux.Desde.DayOfYear <= i.Desde.DayOfYear && aux.Hasta.DayOfYear <= i.Desde.DayOfYear)
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }
        public List<Descuentos> descuentoshoy()
        {
            List<Descuentos> listadehoy = new List<Descuentos>();
            foreach(Descuentos d in desc.GetList())
            {
                if (d.Desde.DayOfYear <= DateTime.Today.DayOfYear && d.Hasta.DayOfYear >= DateTime.Today.DayOfYear)
                    listadehoy.Add(d);
            }
            return listadehoy;
        }
        /*Inutilizado actualmente, DATAVIEW.
        public List<string> listarcategoria()
        {
            //Retorna una lista de strings con los nombres de las categorias.
            //Añadido 9/05/13: Tambien devuelve las fechas...
            List<string> listacat = new List<string>();
            foreach (Descuentos aux in desc.GetList())
                listacat.Add("En " + aux.Categoria.Nombre + " desde: " + aux.Desde.ToString() + " Hasta: " + aux.Hasta.ToString());
            return listacat;
        }
      */
        public List<Descuentos> getlist()
        {
            return desc.GetList();
        }
    }
}
