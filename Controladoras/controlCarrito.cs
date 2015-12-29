using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAO;
namespace Controladoras
{
    public class controlCarrito
    {
        listaCategoria lCategorias = listaCategoria.singleton();
        listaProducto lProducto = listaProducto.singleton();
        controlDesc conDescuentos = new controlDesc();
        carrito carro = new carrito();

        public void agregarproducto(Producto p, int cantidad)
        {
            decimal DESCUENTO = p.PrecioReal;
            foreach (Descuentos desc in conDescuentos.descuentoshoy())
                if (p.CATEGORIA.Nombre == desc.Categoria.Nombre)
                {
                    DESCUENTO -= DESCUENTO * desc.Dct / 100;
                }
            lineaItem Item = new lineaItem(p,cantidad,DESCUENTO);
            carro.agregar(Item);
        }
        public decimal total()
        {
            decimal x=0;
            foreach (lineaItem L in carro.lista())
            {
                x += L.Subtotal;
            }
            return x;
        }
        public List<lineaItem> Items
        {
            get { return carro.lista(); }
        }
    }
}
