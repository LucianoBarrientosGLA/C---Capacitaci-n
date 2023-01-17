using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Declarar dos variables n1=5 y n2=10.
            Utilizando concatenación entre las variables
            y los literales, mostrar en pantalla la siguiente
            expresión:
            n1 es igual a 5, n2 es igual a 10 y n1 más n2 es
            igual a 15.*/

            int n1 = 5;
            int n2 = 10;
            int n3 = n1 + n2;

            Console.WriteLine($"n1 es igual a {n1}, n2 es igual a {n2} y n1 más n2 es igual a {n3}");
            Console.ReadKey();
        }
    }
}
