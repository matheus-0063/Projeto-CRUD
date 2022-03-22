using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud
{
    public class SelectDados
    {
        public void buscarDados(string valor)
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = "server=localhost; database=projetodonuz; user id=root; password=127564620mA.; port=3306;";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandType = CommandType.Text;
            conexao.Open();
            if (valor == "3") 
            {
                return;
            }
            Console.Write("Digite o ID: ");
            string id = Console.ReadLine();
            switch (valor)
            {
                case "1":
                    cmd.CommandText = "SELECT * FROM tabela_de_clientes where id_cliente = ?";
                    cmd.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = id;
                    MySqlDataReader dados = cmd.ExecuteReader();
                    while (dados.Read())
                    {
                        Console.WriteLine("ID CLIENTE \t NOME \t\t CPF \t\t E-MAIL \t\tENDEREÇO");
                       Console.WriteLine(dados["id_cliente"].ToString() + "\t\t" + dados["nome"].ToString() + "\t\t" + dados["cpf"].ToString() + "\t\t" + dados["email"].ToString() + "\t\t" + dados["endereco"].ToString());
                    }
                    break;

                case "2":
                    cmd.CommandText = "SELECT * FROM tabela_de_pontos where id_cliente = ?";
                    cmd.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = id;
                    MySqlDataReader dados1 = cmd.ExecuteReader();
                    while (dados1.Read())
                    {
                        Console.WriteLine("ID CLIENTE \tVALOR\tDESCRIÇAO");
                        Console.WriteLine(dados1["id_cliente"].ToString() + "\t\t" + dados1["valor"].ToString() + "\t" + dados1["descricao"].ToString());
                    }
                    break;
            }
            conexao.Close();
        }
    }
}
