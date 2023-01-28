using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
   public abstract class Conexion
    {
        private readonly string con;

        public Conexion()
        {
            con = "Server = BOCA_JUNIORS; DataBase=Biblioteca; integrated security = true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(con);
        }
    }
}
