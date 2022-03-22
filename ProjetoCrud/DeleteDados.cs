using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud
{
    public class DeleteDados
    {
        public void deletarDados()
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = "server=localhost; database=projetodonuz; user id=root; password=127564620mA.; port=3306;";
            conexao.Open();
            MySqlCommand cmd = conexao.CreateCommand();

            Console.Write("Digite o ID que deseja DELETAR: ");
             string iD = Console.ReadLine();
             cmd.CommandText = "DELETE FROM tabela_de_clientes WHERE id_cliente = ?";
             cmd.Parameters.Clear();
             cmd.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = iD;
             cmd.ExecuteNonQuery();

            conexao.Close();
        }
    }
}
