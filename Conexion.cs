
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection("server = localhost; database = contacts; Uid = root; pwd =;");

            conectar.Open();

         
            return conectar;
        }

      

    }
}
