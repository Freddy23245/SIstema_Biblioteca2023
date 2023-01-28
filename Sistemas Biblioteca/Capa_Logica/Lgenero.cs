using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;

namespace Capa_Logica
{
    public class Lgenero
    {
        Dgenero genero = new Dgenero();
        public void insertar(string nombre)
        {
            genero.insertar(nombre);
        }

        public void editar(int id_genero,string nombre)
        {
            genero.editar(id_genero, nombre);
        }
        public void eliminar(int id_genero)
        {
            genero.eliminar(id_genero);
        }
        public DataTable mostrar()
        {
            return genero.mostrar();
        }
    }

}