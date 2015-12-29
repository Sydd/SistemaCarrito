using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    /*Interfaz de DAO en general*/
    public interface Idao<T>
    {
        //3 metodos basicos.
        void Agregar(T data);
        void Borrar(T data);
        void Modificar(T data_amodificar);
        //Retorno de la lista;
        List<T> GetList();
        //2 Metodos de busca;
        T BuscarporID(int ID);
        T BuscarporNombre(string nombre);
    }
}
