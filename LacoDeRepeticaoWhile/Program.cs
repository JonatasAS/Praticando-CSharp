using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //executando contagem com o while
            Console.WriteLine("Laço de repetição while");
            int contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++; 
             

            }
            Console.ReadLine();

            //executando contagem com o for
            Console.WriteLine("Laço de repetição For");

            for (int contador2 = 0; contador2 <= 10; contador2++)
            {
                Console.WriteLine(contador2);
            }
            Console.ReadLine();
        }

    }
}
