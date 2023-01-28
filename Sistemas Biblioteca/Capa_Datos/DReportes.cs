using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capa_Datos
{
    public class DReportes:Conexion
    {

        public int CantidadAlumnos()
        {
            int cant;
            using (var conetion = GetConnection())
            {

                conetion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conetion;
                    cmd.CommandText = "Sp_CantidadAlumnos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    
                    SqlParameter Pmen = new SqlParameter("@cantidad", SqlDbType.VarChar);
                    Pmen.Direction = ParameterDirection.Output;
                    Pmen.Size = 100;
                    cmd.Parameters.Add(Pmen);

                    cmd.ExecuteNonQuery();

                    cant = Convert.ToInt32(cmd.Parameters["@cantidad"].Value.ToString());


                }

            }
            return cant;
        }


        public int CantidadLibros()
        {
            int cant;
            using (var conetion = GetConnection())
            {

                conetion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conetion;
                    cmd.CommandText = "Sp_CantidadLibros";
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter Pmen = new SqlParameter("@cantidad", SqlDbType.VarChar);
                    Pmen.Direction = ParameterDirection.Output;
                    Pmen.Size = 100;
                    cmd.Parameters.Add(Pmen);

                    cmd.ExecuteNonQuery();

                    cant = Convert.ToInt32(cmd.Parameters["@cantidad"].Value.ToString());


                }

            }
            return cant;
        }
        public int CantidadNodevueltos()
        {
            int cant;
            using (var conetion = GetConnection())
            {

                conetion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conetion;
                    cmd.CommandText = "Sp_CantidadPrestada";
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter Pmen = new SqlParameter("@cantidad", SqlDbType.VarChar);
                    Pmen.Direction = ParameterDirection.Output;
                    Pmen.Size = 100;
                    cmd.Parameters.Add(Pmen);

                    cmd.ExecuteNonQuery();

                    cant = Convert.ToInt32(cmd.Parameters["@cantidad"].Value.ToString());


                }

            }
            return cant;
        }

        public int CantidadDevueltos()
        {
            int cant;
            using (var conetion = GetConnection())
            {

                conetion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conetion;
                    cmd.CommandText = "Sp_CantidadDevuelta";
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter Pmen = new SqlParameter("@cantidad", SqlDbType.VarChar);
                    Pmen.Direction = ParameterDirection.Output;
                    Pmen.Size = 100;
                    cmd.Parameters.Add(Pmen);

                    cmd.ExecuteNonQuery();

                    cant = Convert.ToInt32(cmd.Parameters["@cantidad"].Value.ToString());


                }

            }
            return cant;
        }

        public int CantidadPrestamos()
        {
            int cant;
            using (var conetion = GetConnection())
            {

                conetion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conetion;
                    cmd.CommandText = "Sp_CantidadPrestamos";
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter Pmen = new SqlParameter("@cantidad", SqlDbType.VarChar);
                    Pmen.Direction = ParameterDirection.Output;
                    Pmen.Size = 100;
                    cmd.Parameters.Add(Pmen);

                    cmd.ExecuteNonQuery();

                    cant = Convert.ToInt32(cmd.Parameters["@cantidad"].Value.ToString());


                }

            }
            return cant;
        }

        public decimal Recaudacion()
        {
            decimal cant;
            using (var conetion = GetConnection())
            {

                conetion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conetion;
                    cmd.CommandText = "Sp_Recaudacion";
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter Pmen = new SqlParameter("@cantidad", SqlDbType.Float);
                    Pmen.Direction = ParameterDirection.Output;
                    //Pmen.Size = 100;
                    cmd.Parameters.Add(Pmen);

                    cmd.ExecuteNonQuery();

                    cant = Convert.ToDecimal(cmd.Parameters["@cantidad"].Value.ToString());


                }

            }
            return cant;
        }





    }
}
