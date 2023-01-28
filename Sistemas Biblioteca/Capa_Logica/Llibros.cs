using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;

namespace Capa_Logica
{
    public class Llibros
    {
        Dlibro libro = new Dlibro();
        public void insetar(int id_autor,int id_genero,int id_editorial,string nombre,string ISBN,DateTime año,string idioma,int id_estado)
        {

            libro.insertar(id_autor, id_genero, id_editorial, nombre,ISBN, año,idioma,id_estado);
        }
        public void editar(int id_libro,int id_autor,int id_genero,int id_editorial,string nombre,string ISBN,DateTime año,string idioma,int id_estado)
         {
             libro.editar(id_libro, id_autor, id_genero, id_editorial, nombre, ISBN, año, idioma, id_estado);
         }

        public void eliminar(int id_libro)
        {
            libro.eliminar(id_libro);
        }
        public DataTable mostrar()
        {
            return libro.mostar();
        }
        public DataTable mostrarEstado()
        {
            return libro.mostarEstados();
        }
    }
}
