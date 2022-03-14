using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_testandoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("testando condicionais");

            int idade = 14;

            int quantidadePessoas = 3;

            if (idade >= 18) // Condição se
            {
                Console.WriteLine("Você tem mais de 18 anos");
                Console.WriteLine("Seja bem vindo!");

            }
            else // condição se não
            {
                if (quantidadePessoas >= 3) //incluindo uma condição dentro de outra 
                {
                    Console.WriteLine("Você possui menos de 18 anos, " +
                                      "mas esta acompanhado, pode entrar");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar");
                }

            }

            Console.ReadLine();




        }
    }
}
