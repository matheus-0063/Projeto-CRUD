using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud
{
    public class InsertDadosConsole : InserirDados
    {
        public void inserirDadosConsole()
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = "server=localhost; database=projetodonuz; user id=root; password=127564620mA.; port=3306;";
            conexao.Open();
            MySqlCommand cmd = conexao.CreateCommand();

            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite o E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Digite o endereço: ");
            string endereco = Console.ReadLine();
            

            InserirDadosWorkbench(cmd, nome, cpf, email, endereco);
            conexao.Close();
        }
    }
}


