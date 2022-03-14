using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Tabuada1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)//laço externo
            {
                for (int contador = 0; contador <= 10; contador++)//laço interno 
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
