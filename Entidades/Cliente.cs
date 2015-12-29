using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        int Id;
        string nombre;
        string username;
        string password;
        DateTime fechaderegistro;
        public Cliente(string _NOMBRE, string _USERNAME, string _PASSWORD, int _id)
        {
            ID = _id;
            nombre = _NOMBRE;
            username = _USERNAME;
            password = _PASSWORD;
            fechaderegistro = DateTime.Today;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

    }
}
