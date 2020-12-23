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

        public static List<contact> Query()
        {
            List<contact> lista = new List<contact>();
            MySqlCommand comando = new MySqlCommand(string.Format("select * from contact"), Conexion.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                contact c = new contact();
                c.Idd = reader.GetString(0);
                c.Name = reader.GetString(1);
                c.LastName = reader.GetString(2);
                c.Address = reader.GetString(3);
                c.Phone = reader.GetString(4);
                c.Email = reader.GetString(5);
                c.Created = reader.GetString(6);
                
                lista.Add(c);
            }
            return lista;

        }

    }
}
