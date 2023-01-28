using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;
namespace Capa_Logica
{
    public class Lprestar
    {
        Dprestamo prestamo = new Dprestamo();
        public void insertar(int id_alumno, int id_libro, DateTime fecha_max)
        {
            prestamo.insertar(id_alumno,id_libro,fecha_max);
        }
        public void editar(int id_prestamo, int id_alumno, int id_libro, DateTime fecha_max)
        {
            prestamo.editar(id_prestamo, id_alumno, id_libro, fecha_max);
        }
        public DataTable LibrosNOdevueltos()
        {
            return prestamo.LibrosNOdevueltos();
        }
        public DataTable LibrosDevueltos()
        {
            return prestamo.LibrosDevueltos();
        }
        public  DataTable mostrar_deuda(int id_alumno)
        {
         
          return prestamo.VerificarDeuda(id_alumno);

        }
        public DataTable ReporteRecaudado(int año)
        {

            return prestamo.ReporteRecaudacion(año);

        }
        public  DataTable mostrar()
        {
            return prestamo.mostar();
        }

        public void retornar(int id_prestamo,int id_libro)
        {
            prestamo.retornar(id_prestamo, id_libro);
        }
        public void eliminar(int id_prestamo)
        {
            prestamo.eliminar(id_prestamo);
        }
    

    }
}
