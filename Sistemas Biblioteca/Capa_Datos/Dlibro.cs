using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class Dlibro:Conexion
    {
        SqlCommand cmd = new SqlCommand();

        public void insertar(int id_editor, int id_genero, int id_editorial, string nombre,string ISBN, DateTime año_publicacion,string idioma,int id_estado)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "insertar_libro";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_editor", id_editor);
                    cmd.Parameters.AddWithValue("@id_genero", id_genero);
                    cmd.Parameters.AddWithValue("@id_editorial", id_editorial);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@isbn", ISBN);
                    cmd.Parameters.AddWithValue("@año", año_publicacion);
                    cmd.Parameters.AddWithValue("@idioma", idioma);
                    cmd.Parameters.AddWithValue("@id_estado", id_estado);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void editar(int id_libro, int id_editor, int id_genero, int id_editorial, string nombre,string ISBN, DateTime año_publicacion,string idioma,int id_estado)
        {
            using(var con = GetConnection())
            {
                con.Open();
                using(var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "editar_libro";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_libro", id_libro);
                    cmd.Parameters.AddWithValue("@id_autor",id_editor);
                    cmd.Parameters.AddWithValue("@id_genero",id_genero);
                    cmd.Parameters.AddWithValue("@id_editorial",id_editorial);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@isbn", ISBN);
                    cmd.Parameters.AddWithValue("@año", año_publicacion);
                    cmd.Parameters.AddWithValue("@idioma", idioma);
                    cmd.Parameters.AddWithValue("@id_estado", id_estado);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void eliminar(int id_libro)
        {
         using(var con = GetConnection())
         {
             con.Open();
             using(var cmd = new SqlCommand())
             {
                 cmd.Connection = con;
                 cmd.CommandText = "eliminar_libro";
                 cmd.CommandType = CommandType.StoredProcedure;

                 cmd.Parameters.AddWithValue("@id_libro", id_libro);

                 cmd.ExecuteNonQuery();
             }
         }
        }

        public DataTable mostar()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "mostrar_libro";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;

                }
            }

        }
        public DataTable mostarEstados()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SpMostrarEstados";
                    cmd.CommandType = CommandType.StoredProcedure;

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
