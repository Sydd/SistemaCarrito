using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public  class Descuentos
    {
        DateTime desde;
        DateTime hasta;
        int dct;
        int id;
        Categoria cat;      

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Categoria Categoria
        {
            get { return cat; }
            set { cat = value; }
        }

        public Descuentos()
        { }
        public Descuentos(DateTime _DESDE, DateTime _HASTA, int _DCT,Categoria _CAT, int _ID)
        {
            desde = _DESDE;
            hasta = _HASTA;
            dct = _DCT;
            cat = _CAT;
            id = _ID;
        }
        public DateTime Desde
        {
            get { return desde; }
            set { desde = value; }
        }
        
        public DateTime Hasta
        {
            get { return hasta; }
            set { hasta = value; }
        }
        
        public int Dct
        {
            get { return dct; }
            set { dct = value; }
        }
        public string Nombre
        {
            get { return Categoria.Nombre + " con un descuento de " + dct.ToString() + "% !!";}
               
        }
    }
}
