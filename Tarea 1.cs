using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1234;
            int user;
            int pass = 1111;
            int clave;
            do
            {
                Console.WriteLine("Ingrese el usuario");
                user = Convert.ToInt32(Console.ReadLine());
                if (user != id)
                    Console.WriteLine("Usuario Invalido. Reintente");
            } while (id != user);

            do
            {
                Console.WriteLine("Ingrese Clave");
                clave = Convert.ToInt32(Console.ReadLine());
                if (clave != pass)
                    Console.WriteLine("Clave Invalida. Reintente");
            } while (pass != clave);


            Console.Clear();
            Console.WriteLine("BIENVENIDO AL SISTEMA");

            Console.ReadKey();
        }

    }
}
