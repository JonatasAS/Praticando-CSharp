using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;

            int quantidadePessoas = 2;

            if (idadeJoao >= 18) //Representação da expressão sendo avaliada pela condição IF(se)
            {
                Console.WriteLine(" João possi mais de 18 anos de idade. Pode entrar");

            }
            else //Representação da expressão sendo avalidada pela condição ELSE(se não)
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui 18 anos, mas esta acompanhado");
                }
                else
                {
                    Console.WriteLine("João não possui mais que 18 anos, não pode entrar.");
                }

            }
            // O programa vai executar de acordo com o bloco de codigo se atende as condições impostas 

            Console.ReadLine();

        }
    }
}
