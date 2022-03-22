using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud
{
    public class MenuAtualizarDados
    {
        public string menuAtualizar()
        {
             Console.WriteLine("=================================");
             Console.WriteLine("" +
                 "Qual coluna deseja ATUALIZAR\n" +
                 "[ 1 ] para atualizar o NOME\n" +
                 "[ 2 ] para atualizar o CPF\n" +
                 "[ 3 ] para atualizar o E-MAIL\n" +
                 "[ 4 ] para atualizar o ENDEREÇO\n" +
                 "[ 5 ] para SAIR");
             Console.WriteLine("=================================");
             Console.Write("O que deseja fazer: ");
             string numAtualizar = Console.ReadLine();
             return numAtualizar;
        }
    }
}
