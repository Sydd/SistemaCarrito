using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    //El constructor esta comentado porque por ahora no hay necesidad de 
    //crear los atributos cuando se instancia la clase.
    public class Categoria
    {
        string nombre;
        string descripcion;
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Categoria(string NOMBRE, string DESC, int _ID)
        {
            nombre = NOMBRE;
            descripcion = DESC;
            id = _ID;
        }
        public string Nombre
        {
            set {nombre = value; }
            get { return nombre; }
        }
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

    }
}
