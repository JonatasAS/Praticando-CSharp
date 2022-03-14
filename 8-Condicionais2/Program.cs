using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condionais 2");

            int idade = 18;
            int quantidade = 1;
            bool acompanhado = quantidade >= 2; // variavel do tipo boolean, guarda um valor TRUE ou FALSE

            //bool acompanhado = true;

            if (idade >= 18 || acompanhado) // duas condições utilizando o operador logico ||ou, com o operador logico ==igualdade 
            {
                Console.WriteLine("Entrada permitida");
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Negada a entrada");
            }


            Console.ReadLine();
        }
    }
}
