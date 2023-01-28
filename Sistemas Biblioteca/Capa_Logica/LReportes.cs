using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
namespace Capa_Logica
{
    public class LReportes
    {
        DReportes rep = new DReportes();
        public int CantidadAlumnos()
        {
            return rep.CantidadAlumnos();
        }

        public int CantidadLibros()
        {
            return rep.CantidadLibros();
        }
        public int CantidadNoDevueltos()
        {
            return rep.CantidadNodevueltos();
        }
        public int CantidadDevueltos()
        {
            return rep.CantidadDevueltos();
        }
        public int CantidadPrestamos()
        {
            return rep.CantidadPrestamos();
        }
        public decimal Recaudacion()
        {
            return rep.Recaudacion();
        }

    }
}
