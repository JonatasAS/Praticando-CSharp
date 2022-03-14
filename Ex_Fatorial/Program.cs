using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculando fatorial de 1 a 10");


            for (int i = 0; i <= 10; i++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {

                    Console.WriteLine(i + " * " + contador + " = " + i * contador);
                    Console.WriteLine();

                }
                Console.WriteLine();

            }
            Console.ReadLine();



        }
    }
}
