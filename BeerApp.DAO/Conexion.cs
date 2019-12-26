using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerApp.DAO
{
    public class Conexion
    {
        private static Conexion instancia;
        public static Conexion Instancia
        {
            get
            {
                if (instancia == null) instancia = new Conexion();
                return instancia;
            }
        }
        public SqlConnection getConexion()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["sistema"].ConnectionString);
        }
    }
}
