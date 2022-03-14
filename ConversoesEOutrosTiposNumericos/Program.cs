using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pontoFlutuante = 3.14f;
            Console.WriteLine("Pi e igual = " + pontoFlutuante);

            double salario = 1270.50;
            int valor = (int)salario; //casting
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            double idade = 30.0;
            Console.WriteLine("A idade de Marcos é " + (int)idade + "!"); // Estamos fazendo o type cast no double, que tem seu valor convertido para int

            int idade2 = 20;
            Console.WriteLine("A idade de Marcos é 30!");

            int valor4 = 50;
            double valor5 = 80.67 + 50;
            Console.WriteLine(valor5);


            Console.ReadLine();

        }
    }
}
