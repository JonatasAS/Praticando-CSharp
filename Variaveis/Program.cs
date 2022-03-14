using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 24;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade + "!");

            Console.Write("Somente o comando White não pula linha. ");

            Console.WriteLine("Execução finalizada tecle enter para fechar");
            Console.ReadLine();
        }
    }
}
