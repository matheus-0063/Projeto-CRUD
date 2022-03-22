using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud
{
    public  class InsertPontos 
    {
        public int ID_Cliente { get; set; }
        public float Valor { get; set; }
        public string Descricao { get; set; }

        public void inserirPontosWorkbench(MySqlCommand cmd, int id, float valor, string descricao)
        {   
            cmd.CommandText = "Insert into tabela_de_pontos (id_cliente, valor, descricao) values (null, ?, ?)";
            cmd.Parameters.Add("@valor", MySqlDbType.Float).Value = valor;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 200).Value = descricao;
            cmd.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();

            ID_Cliente = id;
            Valor = valor;
            Descricao = descricao;

        }
    }
}
