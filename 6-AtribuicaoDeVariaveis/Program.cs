using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicaoDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 6");

            int idade = 32;
            int idadeGustavo = idade;//Atribuindo uma variavel a outra 

            idade = 20;// alterando o valor da primeira variavel 

            Console.WriteLine(idade);//primeira variavel o C# realiza a alteração 
            Console.WriteLine(idadeGustavo);//Na segunda variavel o C# não da muito foco para alteração

            string parcela_1 = "10";
            string parcela_2 = "20";
            Console.WriteLine(parcela_1 + parcela_2);//concatenação
            

            Console.ReadLine();

        }
    }
}
