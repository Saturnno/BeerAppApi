using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerApp.STR;

namespace BeerApp.DAO
{
    public class daoProductos
    {
        public strRespuesta Obtener()
        {
            var objConn = Conexion.Instancia.getConexion();
            SqlCommand objCmd = new SqlCommand("Catalogo_Obtener_Productos", objConn);
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.CommandTimeout = 3600;
            strRespuesta res = null;

            List<strProductos> l = new List<strProductos>();
            try
            {
                objConn.Open();
                SqlDataReader lector = objCmd.ExecuteReader();
                while (lector.Read())
                {
                    strProductos str = new strProductos();
                    str.ID = int.Parse(lector["ID"].ToString());
                    str.Nombre = lector["Nombre"].ToString();
                    str.Imagen = lector["Imagen"].ToString();
                    str.Categoria = int.Parse(lector["Categoria"].ToString());
                    str.Precio = decimal.Parse(lector["Precio"].ToString());
                    l.Add(str);
                }
                res = new strRespuesta() { IsError = false, Message = "", Productos = l};


            }
            catch (Exception e)
            {
                res = new strRespuesta() { IsError = true, Message = "Ha ocurrido un problema al traer los productos." };

            }
            finally
            {
                objConn.Close();
            }

            return res;
        }
    }
}
