using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoDeRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo do Imposto de Renda IRPF");

            //Abaixo de 1903.98 esta isento
            //De 1903.99 até 2826.65, o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142.80
            //De 2826.66 até 3751.05, o IR é de 15 % e pode deduzir R$ 354.80
            //De 3751.05 até 4664.68, o IR é de 22.5 % e pode deduzir R$ 636
            //Acima de 4664.68, IR é de 27.5 % e pode deduzir R$ 869.36

            double salario = 3300.00;

            if (salario <= 1903.98)
            {
                Console.WriteLine("Seu salario e de " + salario + " esta isento");
            }
            else if (salario >= 1903.99 && salario <= 2826.65)
            {
                Console.WriteLine("Seu salarario e de " + salario + " IR e de 7.5%.");
                Console.WriteLine("Podendo deduzir na declaração o valor de R$ 142.80.");
            }
            else if (salario >= 2826.66 && salario <= 3751.05)
            {
                Console.WriteLine("Seu salarario e de " + salario + " IR e de 15%.");
                Console.WriteLine("Podendo deduzir na declaração o valor de R$ 354.80.");
            }
            else if (salario >= 3751.05 && salario <= 4664.68)
            {
                Console.WriteLine("Seu salarario e de " + salario + " IR e de 22.5%.");
                Console.WriteLine("Podendo deduzir na declaração o valor de R$ 636.13.");
            }
            else
            {
                Console.WriteLine("Seu salario esta acima dos 4664.68, alíquota de 27.5%.");
                Console.WriteLine("Podendo deduzir o valor de R$ 869.36.");
            }
            Console.ReadLine();
        }
    }
}
