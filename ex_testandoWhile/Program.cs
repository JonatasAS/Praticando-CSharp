using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_testandoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contando de 1 a 10");

            int contador = 1;// criação da varivael e inicialização do contador

            while(contador <=10)//expressão booleana
            {
                Console.WriteLine(contador);
                contador++; //incrementar a variavel com as interações com o while para não gerar um loop infinito
            }

            Console.ReadLine();
        }
    }
}
