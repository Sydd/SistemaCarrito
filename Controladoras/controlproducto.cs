using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAO;
namespace Controladoras
{
    //
    //Controladora de la gestion y clase producto.
    //
    public class controlproducto
    {
        listaProducto lPro = listaProducto.singleton();
        controlCate controlcategoria = new controlCate();
        public void nuevo(string _Nombre, decimal _Precio, string _categoria)
        {
            
            
            int ID = lPro.GetList().Count == 0 ? 0 : lPro.GetList()[lPro.GetList().Count - 1].Id + 1;
            
            Categoria aux = controlcategoria.buscarporstring(_categoria);
            Producto nuevo = new Producto(ID, _Precio, _Nombre, aux);
            agregar(nuevo);
        }
        void agregar ( Producto a)
        {
            lPro.Agregar(a);
        }
        public void borrar(int ID)
        {
            lPro.Borrar(lPro.BuscarporID(ID));
        }
        public List<Producto> Lista()
        {
            return lPro.GetList();
        }
        public List<Producto> ListaPorCategoria(Categoria C)
        {
            List<Producto> l = new List<Producto>();
            foreach ( Producto P in lPro.GetList())
                    if (P.CATEGORIA.Equals(C))
                        l.Add(P);
            return l;
        }
    }
}
