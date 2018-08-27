using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;
            Console.WriteLine("Ingrese una letra");
            letra = Console.ReadLine();
            if(letra!="a" && letra!="e" && letra!="i" && letra !="o" && letra !="u")
            {
                Console.WriteLine("La letra es una consonante");
            }
            else
            {
                Console.WriteLine("La letra es una vocal");
            }
            Console.ReadKey();
        }
    }
}
