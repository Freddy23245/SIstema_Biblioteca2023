using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos{

    public class Dalumnos:Conexion
    {
        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarAlumnos()
        {
            using(var con = GetConnection())
            {
                con.Open();
                using(var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "mostrar_alumnos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;

                }
            }
        }
        public DataTable Deuda(int id_alumno)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
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

        public void insertar(string nombre, string apellido, string dni, string telefono, string direccion, string mail)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "insertar_alumnos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido",apellido);
                    cmd.Parameters.AddWithValue("@dni",dni);
                    cmd.Parameters.AddWithValue("@telefono",telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@mail", mail);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void editar(int id_alumno,string nombre, string apellido, string dni, string telefono, string direccion, string mail)
        {
            using(var con = GetConnection())
            {
                con.Open();
                using(var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "editar_alumnos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_alumno", id_alumno);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@mail", mail);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void eliminar(int id_alumno)
        {
            using(var con = GetConnection())
            {
                con.Open();
                using(var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "eliminar_alumnos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_alumno", id_alumno);

                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
