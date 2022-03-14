using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 9 escopo");

            int idadeJoao = 18;
            bool acompanhado = false;
            string mensagemAdicional; // Escopo PAI
            // Se a variavel for declarada no inicio do compilador ele funciona para todo o programa
            // Se a variavel for declarada em um bloco especifico podera ser utilizada somente neste bloco {}
            // Variaveis podem podem conter o mesmo nome mas tem que ser declaradas em blocos diferentes {}

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";

            }// As chaves terminam o final do bloco, mas quando a só um comando uma linha nesse bloco as chaves não são necessárias 
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);

            }
            else
            {
                Console.WriteLine("Não pode entrar");

            }
            Console.ReadLine();
        }
    }
}
