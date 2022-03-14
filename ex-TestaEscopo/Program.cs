using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_TestaEscopo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 15;
            int quantidadePessoas = 3;
            bool acompanhado;
            string qPessoas;

            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
                qPessoas = "Esta acompanhado";
            }
            else
            {
                acompanhado = false;
                qPessoas = "Não esta acompanhado";
            }
            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo!");
                Console.WriteLine(qPessoas);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
                Console.WriteLine(qPessoas);
            }

            Console.ReadLine();

        }
    }
}
