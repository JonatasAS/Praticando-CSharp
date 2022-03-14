using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_testando_condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 18;
            int quantidadePessoas = 3;
            bool acompanhado;
            string mensagemA;
    

            if (acompanhado = quantidadePessoas >=2 )
            {
                mensagemA = "Esta acompanhado por " + quantidadePessoas + " pessoas";
            }
            else
            {
                mensagemA = "Não esta acompanhado";
            }


            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemA);
        
            }
            else
            {
                Console.WriteLine("Não pode entrar");

            }
            Console.ReadLine();


        }
    }
}
