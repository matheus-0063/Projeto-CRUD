using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud
{
    public class MenuDeOperacoes : InsertDadosConsole
    { 
        public string menuOperacoes()
        {
        Console.WriteLine("=================================");
            Console.WriteLine("\t MENU DE ESCOLHAS");
            Console.WriteLine("=================================");
            Console.Write("" +
                "[ 1 ] para INSERIR os dados\n" +
                "[ 2 ] para ATUALIZAR algum dado\n" +
                "[ 3 ] para EXCLUIR algum dado\n" +
                "[ 4 ] para BUSCAR os dados\n" +
                "[ 5 ] para INSERIR pontos\n" +
                "[ 6 ] para SAIR\n" +
                "=================================\n" +
                "O QUE DESEJA FAZER: ");

            string numMenu = Console.ReadLine();
            return numMenu;


        }
    }
}