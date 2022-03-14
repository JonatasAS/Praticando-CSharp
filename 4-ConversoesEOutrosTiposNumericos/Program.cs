using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario; // O int e um tipo de variavel que suporta até 32 bits
            //Para forçar o int aceitar  um valor double e necessário colocalo em (int)variavel conhecido como casting, mas se perde precisão no resultado

            Console.WriteLine(salarioEmInteiro);

            long idade = 13000000000; // O long e um tipo de variavel que suporta até 64 bits
            Console.WriteLine(idade);

            short quantidadeProdutos = 150; // O short e um tipo de variavel que suporta até 16 bits
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.81f; // float aceita casas decimais após a virgula mas e uma variavel menos usual sendo necessário informar o sufixo F no final
            Console.WriteLine(altura);
            // float suporta 32 bits

            //Console.WriteLine() suporta texto, número inteiro, double, short e long, todos que foram apresentados no codigo



            Console.ReadLine();
        }
    }
}
