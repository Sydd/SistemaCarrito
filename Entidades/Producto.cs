using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    //Clase producto. Un producto tiene una categoria.
    
    public class Producto
    {
        int id;
        decimal precio;
        string nombre;
        Categoria categoria;

        public Categoria CATEGORIA
        {
            get { return categoria; }
        }

        public Producto(int ID, decimal PRECIO, string NOMBRE, Categoria aux)
        {
            id = ID;
            precio = PRECIO;
            nombre = NOMBRE;
            categoria = aux;
        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public decimal PrecioReal
        {
            set { precio = value; }
            get { return precio; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Precio
        {
            get { return  '$' + precio.ToString(); }
        }
        
    }
}
