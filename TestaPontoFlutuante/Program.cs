using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 1250.70;
            Console.WriteLine(salario);

            double teste = 125.50; //compila
            Console.WriteLine(teste);

            int divisao = 5 / 2; //limitação numerica valor truncado 
            Console.WriteLine(divisao);

            //Exemplo de operações de double para inteiros

            double divisao2 = 5.0 / 2; //double aceita valor inteiro mas para oferecer um valor double sempre vai solicitar uma casa depois da virgula no momento da operação
            Console.WriteLine(divisao2);

            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);

            int dia = 4;
            int outroDia = 4 + dia;
            Console.WriteLine(outroDia);

            double preco = 5.5;
            int ingressos = 4;
            Console.WriteLine(preco * ingressos);


              
            Console.WriteLine("A execução terminou, tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}
