using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dados n1=true, n2=false y n3=true.
            Informar:
                a.n1 ^ n2
                b. (n1 & !n2) | n3
                c. (n1 | n2) & !n3
            */
            bool n1 = true;
            bool n2 = false; 
            bool n3 = true;

            Console.WriteLine(" n1 ^ n2= " + (n1 ^ n2));
            Console.WriteLine("(n1 & !n2) | n3= " + ((n1 & !n2) | n3));
            Console.WriteLine("(n1 | n2) & !n3= " + ((n1 | n2) & !n3));
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
 

        }
    }
}
