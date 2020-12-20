using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class controller
    {
        public static int Insertar(string name,string lastname, string address, string phone, string email)
        {
            
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into  contact(name, lastname, address, phone, email, created_at) values('{0}','{1}','{2}', '{3}','{4}',now())", name, lastname,address, phone,email), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }

    }
}
