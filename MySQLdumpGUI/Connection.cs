using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLdumpGUI
{
    public class Connection
    {
        static MySqlConnection conectar;

        public static MySqlConnection Connect
        {
            get { return conectar; }
            set { conectar = value; }
        }

        public static String CreateConnection(string user, string password)
        {
            if (conectar != null)
            {
                conectar.Close();
            }
            string configuracao = string.Format("server={0};user id={1}; password={2};database=mysql; pooling=false", "127.0.0.1", user, password);
            try
            {
                conectar = new MySqlConnection(configuracao);
                conectar.Open();
            }
            catch (MySqlException erro)
            {
                return ("Erro ao conectar " + erro);
            }

            return ("Connected");
        }
    }
}
