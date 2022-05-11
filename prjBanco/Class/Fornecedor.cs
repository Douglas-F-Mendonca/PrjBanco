using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using prjBanco.Conn;

namespace prjBanco.Class
{
    class Fornecedor
    {
        private int id;
        private string razaoSocial;
        private string email;

        public int Id { get => id; set => id = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Email { get => email; set => email = value; }

        public static void cadastrar(Fornecedor f)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO  fornecedor VALUES (null, @RAZAOSOCIAL, @EMAIL)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RAZAOSOCIAL", f.razaoSocial);
                cmd.Parameters.AddWithValue("@EMAIL", f.email);
                cmd.ExecuteNonQuery();

                Conexao.fecharConexao();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }

        }
    }
}
