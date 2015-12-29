using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;
namespace Controladoras
{
    class controlCliente
    {
        listaCliente lClientes = listaCliente.Singleton();
        public void NuevoCliente(string Nombre,string User, string Pass)
        {
            Cliente nuevo = new Cliente(Nombre, User, Pass, devolverID());
            
        }
        int devolverID()
        {
            int x = lClientes.GetList().Count;
            return x;
        }
      /*  bool comprobarexiste()
        {
            bool    ;
            foreach (Cliente x in lClientes.GetList())
            {
                if (Cliente 
            }
        }*/
    }
}
