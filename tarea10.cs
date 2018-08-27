using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario="Martin", usuario2;


            do
            {
                Console.WriteLine("Ingrese Usuario");
                usuario2 = Console.ReadLine();
                if (usuario != usuario2)
                    Console.WriteLine("No te conozco");
                else
                    Console.WriteLine("Hola {0}", usuario);
            } while (usuario != usuario2);

            Console.ReadKey();
        }
    }
}
