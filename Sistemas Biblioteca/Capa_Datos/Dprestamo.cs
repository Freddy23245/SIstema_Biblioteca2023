using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class Dprestamo : Conexion
    {

        public DataTable mostar()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "mostrar_prestamos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;

                }
            }

        }
        public DataTable LibrosNOdevueltos()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_ReporteNoDevueltos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;

                }
            }

        }
        public DataTable LibrosDevueltos()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_ReporteDevueltos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;

                }
            }

        }

        public void insertar(int id_alumno, int id_libro, DateTime fecha_dev)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "insertar_prestamos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_alumno", id_alumno);
                    cmd.Parameters.AddWithValue("@id_libro", id_libro);
                    cmd.Parameters.AddWithValue("@fecha_max", fecha_dev);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void editar(int id_prestamo, int id_alumno, int id_libro, DateTime fecha_dev)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "editar_prestamos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_prestamo", id_prestamo);
                    cmd.Parameters.AddWithValue("@id_alumno", id_alumno);
                    cmd.Parameters.AddWithValue("@id_libro", id_libro);
                    cmd.Parameters.AddWithValue("@fecha_max", fecha_dev);

                    cmd.ExecuteNonQuery();


                }
            }
        }

        public void eliminar(int id_prestamo)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "eliminar_prestamos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_prestamo", id_prestamo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void retornar(int id_prestamo, int id_libro)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "retornar_libro";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_prestamo", id_prestamo);
                    cmd.Parameters.AddWithValue("@id_libro", id_libro);


                    cmd.ExecuteNonQuery();

                }
            }
        }

        public DataTable VerificarDeuda(int id_alumno)
        {
            using (var conetion = GetConnection())
            {

                conetion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conetion;
                    cmd.CommandText = "Verificar_deuda";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_alumno", id_alumno);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;


                }
            }

        }
        public DataTable ReporteRecaudacion(int año)
        {
            using (var conetion = GetConnection())
            {

                conetion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conetion;
                    cmd.CommandText = "Sp_Recaudaciones";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@año", año);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;


                }
            }

        }
    }
}
