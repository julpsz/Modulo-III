using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5, b, c;
            
            
            Console.WriteLine("El resultado de a=5 es: {0}", a);
                       
            Console.WriteLine("El resultado de b=++a es: {0}", b = ++a);
                       
            Console.WriteLine("El resultado de c = a++ es: {0}", c = a++);
                        
            Console.WriteLine("El resultado de b = b*5 es: {0}", b = b*5);
                        
            Console.WriteLine("El resultado de a = a*2 es: {0}", a = a* 2);
                      
            Console.ReadKey();
        }
    }
}
