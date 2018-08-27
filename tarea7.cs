using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b, c;


            Console.WriteLine("El resultado de a=5 es: {0}", a);

            Console.WriteLine("El resultado de b=a+2 es: {0}", b = a + 2);

            Console.WriteLine("El resultado de b -= 3 es: {0}", b -= 3);

            Console.WriteLine("El resultado de c =- 3 es: {0}", c = -3);

            Console.WriteLine("El resultado de c*=2 es: {0}", c *= 2);

            Console.WriteLine("El resultado de ++c es: {0}", ++c);

            Console.WriteLine("El resultado de a*=b es: {0}", a *= b);

            Console.ReadKey();
        }
    }
}
