using System;
using MySql.Data.MySqlClient;

namespace ProjetoCrud
{
    class Program
    {

        static async Task Main(string[] args)
        {
            MenuDeOperacoes menu = new MenuDeOperacoes();
            var valor = "1";
            while(valor != "6")
            {
                Console.Clear();

                valor = menu.menuOperacoes().Trim();

                switch (valor)
                {

                    case "1":
                        InsertDadosConsole insertDadosConsole = new InsertDadosConsole();
                        insertDadosConsole.inserirDadosConsole();
                        break;


                    case "2":
                        MenuAtualizarDados menuA = new MenuAtualizarDados();
                        UpdateDados upDados = new UpdateDados();
                        upDados.updateDados(menuA.menuAtualizar());
                        break;


                    case "3":
                        DeleteDados delDados = new DeleteDados();
                        delDados.deletarDados();
                        break;

                    case "4":
                        MenuSelectDados menuSelecionar = new MenuSelectDados();
                        SelectDados selecionarDados = new SelectDados();
                        selecionarDados.buscarDados(menuSelecionar.selecionarMenu());
                        break;

                    case "5":
                        InsertPontosConsole insertPontosConsole = new InsertPontosConsole();
                        insertPontosConsole.inserirPontosConsole();
                        break;

                    default:
                        break;
                }
                Console.ReadKey();
            }

        }


           
    }
}
