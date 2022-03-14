using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_MultDe3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 3; i < 100; i += 3 )

            for (int mult = 1; mult < 100; mult++)
            {
                if (mult % 3 == 0)
                    Console.Write(mult + " ,");
                
            }
            Console.ReadLine();
        }
    }
}
