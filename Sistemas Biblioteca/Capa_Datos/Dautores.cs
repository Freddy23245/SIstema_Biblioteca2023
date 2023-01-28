using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capa_Datos
{
   public class Dautores:Conexion
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
                    cmd.CommandText = "mostrar_autores";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;

                }
            }
        }


       public void insertar(string nombre,string apellido, string mail)
        {
           using(var con = GetConnection())
           {
               con.Open();
               using(var cmd = new SqlCommand())
               {
                   cmd.Connection = con;
                   cmd.CommandText = "insertar_autores";
                   cmd.CommandType = CommandType.StoredProcedure;

                   cmd.Parameters.AddWithValue("@nombre", nombre);
                   cmd.Parameters.AddWithValue("@apellido", apellido);
                   cmd.Parameters.AddWithValue("@mail", mail);

                   cmd.ExecuteNonQuery();

               }
           }
        }
       public void editar(int id_autor,string nombre,string apellido,string mail)
       {
           using(var con = GetConnection())
           {
               con.Open();

               using(var cmd = new SqlCommand())
               {
                   cmd.Connection = con;
                   cmd.CommandText = "editar_autores";
                   cmd.CommandType = CommandType.StoredProcedure;

                   cmd.Parameters.AddWithValue("@id_autor", id_autor);
                   cmd.Parameters.AddWithValue("@nombre", nombre);
                   cmd.Parameters.AddWithValue("@apellido", apellido);
                   cmd.Parameters.AddWithValue("@mail", mail);

                   cmd.ExecuteNonQuery();

               }
           }
       }

       public void eliminar(int id_autor)
       {
           using(var con = GetConnection())
           {
               con.Open();
               using(var cmd = new SqlCommand())
               {
                   cmd.Connection = con;
                   cmd.CommandText = "eliminar_autores";
                   cmd.CommandType = CommandType.StoredProcedure;

                   cmd.Parameters.AddWithValue("@id_autor", id_autor);

                   cmd.ExecuteNonQuery();

               }
           }
       }




    }
 }

