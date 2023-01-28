using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;

namespace Capa_Logica
{
    public class Leditoriales
    {
        DEditoriales editorial = new DEditoriales();
        public void insertar(string nombre, string email, int id_pais, string sitio_web)
        {
            editorial.insertar(nombre,email,id_pais,sitio_web);
        }

        public void editar(int id_editorial, string nombre, string email, int id_pais, string sitio_web)
        {
            editorial.editar(id_editorial, nombre, email, id_pais, sitio_web);
        }

        public void eliminar(int id_editorial)
        {
            editorial.eliminar(id_editorial);  
        }
        public DataTable mostrar()
        {
            return editorial.mostrar(); 
        }

        public DataTable mostrarPeises()
        {
            return editorial.mostrarPaises();
        }

    }
}
