using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class carrito
    {
        List<lineaItem> lItems = new List<lineaItem>();

        public List<lineaItem> lista()
        {
            return lItems;
        }
        public void agregar(lineaItem Item)
        {
            lItems.Add(Item);
        }
        public decimal Subtotal
        {
            get 
            { 
                decimal x=0;
                foreach (lineaItem I in lItems)
                    x += I.Subtotal;
                return x;
            }
        }
    }
}
