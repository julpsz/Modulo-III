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
            int num, aux;
            int contador = 0;

            Console.WriteLine("Ingrese un numero entero");
            num = Convert.ToInt32(Console.ReadLine());

            aux = num;
            do
            {
                aux = aux / 10;
                contador++;
            } while (aux != 0);

            Console.WriteLine("El numero {0} tiene {1} cifras", num, contador);
            Console.ReadKey();
        }
    }
}
