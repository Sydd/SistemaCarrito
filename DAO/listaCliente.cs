using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace DAO
{
    public class listaCliente : Idao<Cliente>
    {
        static listaCliente clientes;
        List<Cliente> lClientes = new List<Cliente>(); 
        static public listaCliente Singleton()
        {
            if ( clientes == null)
                clientes = new listaCliente();
            return clientes;
         }
        //3 metodos basicos.
        public void Agregar(Cliente data)
        {
            lClientes.Add(data);
        }
        public void Borrar(Cliente data)
        {
            lClientes.Remove(data);
        }
        public void Modificar(Cliente data_amodificar)
        {
            Cliente aux;
            foreach (Cliente cl in lClientes)
            {
                if (cl.ID == data_amodificar.ID)
                    aux = cl;
                aux = data_amodificar;
            }
        }
        //Retorno de la lista;
        public List<Cliente> GetList()
        {
            return lClientes;
        }
        //2 Metodos de busca;
        public Cliente BuscarporID(int ID)
        {
            Cliente aux = null;
            foreach ( Cliente cl in lClientes)
            {
                if (ID == cl.ID)
                    aux = cl;
            }
            return aux;
        }
        public Cliente BuscarporNombre(string nombre)
        {
            Cliente aux = null;
            foreach (Cliente cl in lClientes)
            {
                if (nombre == cl.Nombre)
                    aux = cl;
            }
            return aux;
        }
    }
}
