using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud
{
    public class MenuSelectDados : SelectDados
    { 
        public string selecionarMenu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Tabelas Disponiveis\n" +
                "[ 1 ] para acessar a TABELA DE CLIENTES\n" +
                "[ 2 ] para acessar a TABELA DE PONTOS\n" +
                "[ 3 ] para SAIR");
            Console.WriteLine("=================================");
            Console.Write("Qual Tabela deseja acessar: ");
            string escolha = Console.ReadLine();
            return escolha;
        }
    }
}
