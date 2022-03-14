using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e texto");


            // character aceita até 16 bits, aceita somente um caracter na variavel
            char primeiraLetra = 'a';// char utliza aspas simples
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65; // realizando um casting de um tipo int para char 
            Console.WriteLine(primeiraLetra); // tipo de variavel char pode estar traduzindo para scii table

            primeiraLetra = (char)(primeiraLetra + 1); // somando um char com um int
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnlogia " + 2021; // tipo de variavel string e utilizado para representação de texto
            string cursosProgramacao = @" - .NET 
 - Java
 - Javascript"; // Montando uma lista de somente com uma string utilizando o @
               // string utiliza aspas duplas
            Console.WriteLine(titulo);              // somando int com string, concatenando        
            Console.WriteLine(cursosProgramacao);

            string saudacao = "Olá, meu nome é ";
            string nome = "Jonatas ";
            string continuacao = "e minha idade é ";
            int idade = 24;
            Console.WriteLine(saudacao + nome + continuacao + idade); //concatenando string e int

            string vazia = ""; // string aceita um variavel vazia 
            char vazia2 = ' '; // char não aceita ficar vaiza necessário um character no caso o espaço
            Console.WriteLine(vazia + vazia2);  

            Console.ReadLine();
        }
    }
}
