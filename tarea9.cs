using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario, c1, c2;

                       
            Console.WriteLine("Ingrese Usuario");
            usuario = Console.ReadLine();
            do
            {
                Console.WriteLine("Ingrese la clave (1era vez)");
                c1 = Console.ReadLine();
                Console.WriteLine("Ingrese la clave (2da vez)");
                c2 = Console.ReadLine();
                if (c1 != c2)
                    Console.WriteLine("Las claves no son iguales.");
            } while (c1 != c2);

            Console.WriteLine("Bienvenido al sistema {0}", usuario);
            Console.ReadKey();        
        }
    }
}
