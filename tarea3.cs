using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i <= 10; i++)
                Console.WriteLine("9 * {0} es: {1}", i, 9 * i);
            Console.ReadKey();
        }
    }
}