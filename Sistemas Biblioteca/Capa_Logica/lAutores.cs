using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
namespace Capa_Logica
{
    public class lAutores
    {
        Dautores autor = new Dautores();
        public void insertar(string nombre,string apellido,string mail)
        {
            autor.insertar(nombre, apellido, mail);
        }

        public void editar(int id_autor,string nombre,string apellido,string mail)
        {
            autor.editar(id_autor, nombre, apellido, mail);
        }
        public void eliminar(int id_autor)
        {
            autor.eliminar(id_autor);
        }

        public  DataTable mostrar()
        {
            return autor.mostrar();
        }
     
    }
}
