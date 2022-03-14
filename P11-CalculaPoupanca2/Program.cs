using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 ");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            // comandos do codigo em somente uma linha, variavel contadora>expressão booleana>variavel de incremento
            {
                valorInvestido *= 1.0036; //simplificando equação 
                Console.WriteLine("Após " + contadorMes + "meses, você terá R$" + valorInvestido);

            }
            Console.ReadLine();
        }
    }
}
