using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ProjetoCrud
{
    public class InserirDados 
    {
        HttpClient client = new HttpClient();
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public virtual void InserirDadosWorkbench(MySqlCommand cmd, string nome, string cpf, string email, string endereco)
        {
            cmd.CommandText = "INSERT INTO tabela_de_clientes (id_cliente, nome, cpf, email, endereco) VALUES (null, ?, ?, ?, ?)";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 20).Value = cpf;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 60).Value = email;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 150).Value = endereco;
            cmd.ExecuteNonQuery();

            Nome = nome;
            CPF = cpf;
            Email = email;
            Endereco = endereco;
        }
    }
}
