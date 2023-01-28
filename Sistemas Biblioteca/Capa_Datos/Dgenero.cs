using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
   public class Dgenero:Conexion
    {
       SqlCommand cmd = new SqlCommand(); 

       public void insertar(string nombre)
       {
          using(var con = GetConnection())
          {
              con.Open();
              using(var cmd = new SqlCommand())
              {
                  cmd.Connection = con;
                  cmd.CommandText = "insertar_genero";
                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.AddWithValue("@nombre", nombre);

                  cmd.ExecuteNonQuery();
              }
          }

       }

       public void editar(int id_genero,string nombre)
       {
          using(var con = GetConnection())
          {
              con.Open();
              using(var cmd = new SqlCommand())
              {
                  cmd.Connection = con;
                  cmd.CommandText = "editar_genero";
                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.AddWithValue("@id_genero", id_genero);
                  cmd.Parameters.AddWithValue("@nombre", nombre);

                  cmd.ExecuteNonQuery();
              }
          }
       }
      public void eliminar(int id_genero)
       {
         using(var con = GetConnection())
         {
             con.Open();
             using(var cmd = new SqlCommand())
             {
                 cmd.Connection = con;
                 cmd.CommandText = "eliminar_genero";
                 cmd.CommandType = CommandType.StoredProcedure;

                 cmd.Parameters.AddWithValue("@id_genero", id_genero);

                 cmd.ExecuteNonQuery();
             }
         }

       }
       public DataTable mostrar()
       {
           using (var con = GetConnection())
           {
               con.Open();
               using (var cmd = new SqlCommand())
               {
                   cmd.Connection = con;
                   cmd.CommandText = "mostrar_genero";
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
