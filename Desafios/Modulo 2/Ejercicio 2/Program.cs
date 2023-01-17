using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primero
            //respecto al segundo.

            Console.Write("Ingrese un numero: ");
            double numUno = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            double numDos = Convert.ToDouble(Console.ReadLine());

            if (numUno > numDos)
            {
                Console.WriteLine($"La suma del primer número con el segundo número es de: {numUno + numDos}, y la diferencia es de: {numUno - numDos}");

            } else
            {
                Console.WriteLine($"El producto de los números es de: {numUno * numDos} y la división de los números es de: {numUno / numDos}");

                
            }
            Console.ReadKey();
        }
    }
}
