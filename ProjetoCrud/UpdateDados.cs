using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud
{
    public class UpdateDados : MenuAtualizarDados
    {
        public void updateDados(string valor)
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = "server=localhost; database=projetodonuz; user id=root; password=127564620mA.; port=3306;";
            conexao.Open();
            MySqlCommand cmd = conexao.CreateCommand();

            if (valor == "5")
            {
                return;
            }

            Console.Write("Qual o ID: ");
            string iD = Console.ReadLine();

            switch (valor)
            {
                case "1":
                    Console.Write("Coloque o novo NOME: ");
                    string nomeAtualizado = Console.ReadLine();
                    cmd.CommandText = "UPDATE tabela_de_clientes set nome = ? where id_cliente = ?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nomeAtualizado;
                    cmd.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = iD;
                    cmd.ExecuteNonQuery();
                    break;

                case "2":
                    Console.WriteLine("Coloque o novo CPF: ");
                    string cpfAtualizado = Console.ReadLine();
                    cmd.CommandText = "UPDATE tabela_de_clientes set cpf = ? where id_cliente = ?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 20).Value = cpfAtualizado;
                    cmd.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = iD;
                    cmd.ExecuteNonQuery();
                    break;

                case "3":
                    Console.Write("Coloque o novo E-MAIL: ");
                    string emailAtualizado = Console.ReadLine();
                    cmd.CommandText = "UPDATE tabela_de_clientes set email = ? where id_cliente = ?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar, 60).Value = emailAtualizado;
                    cmd.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = iD;
                    cmd.ExecuteNonQuery();
                    break;

                case "4":
                    Console.Write("Coloque o novo ENDEREÇO: ");
                    string enderecoAtualizado = Console.ReadLine();
                    cmd.CommandText = "UPDATE tabela_de_clientes set endereco = ? where id_cliente = ?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 150).Value = enderecoAtualizado;
                    cmd.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = iD;
                    cmd.ExecuteNonQuery();
                    break;

                default:
                    Console.WriteLine("Valor invalido");
                    break;
            }
            return;
        }
    }
}
