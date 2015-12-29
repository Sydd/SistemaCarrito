using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class lineaItem
    {
        Producto item;
        decimal precio;
        int cantidad;
        public lineaItem(Producto _ITEM, int _Cantidad, decimal _Precio)
        {
            item = _ITEM;
            precio = _Precio;
            cantidad = _Cantidad;
        }
        public string Nombre
        {
            get { return item.Nombre; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public decimal Subtotal
        {
            get { return precio * cantidad;}
        }


    }
}
