using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;

namespace Capa_Logica
{
    public class Lalumnos
    {

        Dalumnos alum = new Dalumnos();

        public DataTable mostrar()
        {
            return alum.MostrarAlumnos();

        }
        public DataTable Deuda(int id_alumno)
        {
            return alum.Deuda(id_alumno);
        }

        public void insertar(string nombre, string apellido, string dni, string telefono, string direccion, string mail)
        {
            alum.insertar(nombre, apellido, dni, telefono, direccion, mail);
        }

        public void editar(int id_alumno, string nombre, string apellido, string dni, string telefono, string direccion, string mail)
        {
            alum.editar(id_alumno, nombre, apellido, dni, telefono, direccion, mail);
        }

        public void eliminar(int id_alumno)
        {
            alum.eliminar(id_alumno);
        }
    }
}
