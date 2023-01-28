using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class DEditoriales:Conexion
    {

        SqlCommand cmd = new SqlCommand();

        public DataTable mostrar()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "mostrar_editoriales";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;

                }
            }
        }
        public DataTable mostrarPaises()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "Sp_MostrarPaises";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;

                }
            }
        }

        public void insertar(string nombre,string email,int id_pais,string  sitio_web)
        {
          
                 using(var con = GetConnection())
                 {
                        con.Open();
                        using(var cmd = new SqlCommand())
                        {
                            cmd.Connection = con;
                            cmd.CommandText = "insertar_editoriales";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@nombre", nombre);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@id_pais", id_pais);
                            cmd.Parameters.AddWithValue("@sitio_web", sitio_web);

                            cmd.ExecuteNonQuery();
                        }   
                }
           
        }

        public void editar(int id_editorial, string nombre, string email, int id_pais, string sitio_web)
        {
            using(var con = GetConnection())
            {
                con.Open();
                using(var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "editar_editoriales";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_editorial", id_editorial);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@id_pais", id_pais);
                    cmd.Parameters.AddWithValue("@sitio_web", sitio_web);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void eliminar(int id_editorial)
        {
            using(var con = GetConnection())
            {
                con.Open();
                using(var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "eliminar_editorial";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_editorial", id_editorial);

                    cmd.ExecuteNonQuery();

                }
            }
        }



    }
}
