using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace prjBanco.Conn
{
    class Conexao
    {
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection("Server=localhost;Database=exerciciodouglas;Uid=root;Pwd=");
            try
            {
                conn.Open();
            }
            catch (MySqlException e)
            {
                conn = null;
            }
            return conn;
        }

        public static void fecharConexao()
        {
            if(conn != null)
            {
                conn.Close();
            }
        }
    }
}
