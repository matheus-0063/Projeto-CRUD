using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud
{
    public class InsertPontosConsole : InsertPontos
    {
        public void inserirPontosConsole()
        {
            MySqlConnection conexao = new MySqlConnection(); 
            conexao.ConnectionString = "server=localhost; database=projetodonuz; user id=root; password=127564620mA.; port=3306;";
            conexao.Open();
            MySqlCommand cmd = conexao.CreateCommand();

            Console.Write("Digite o ID do cliente que deseja inserir os Pontos: ");
            int iD = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de pontos: ");
            float valor = float.Parse(Console.ReadLine());   
            Console.WriteLine("Qual a descrição: ");
            string descricao = Console.ReadLine();

            inserirPontosWorkbench(cmd, iD, valor, descricao);
        }
    }
}
