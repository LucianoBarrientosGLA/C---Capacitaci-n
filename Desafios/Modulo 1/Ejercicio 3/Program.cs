using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haciendo uso de la constante IVA=21, calcular
            el precio con IVA de los siguientes productos e informar:
            a. Remera: 59.90$
            b. Pantalón: 99.90$
            c. Campera: 149.90$  */

            double remera = 59.90;
            double pantalon = 99.90;
            double campera = 149.90;

            double precioIva = 1.21;

            Console.WriteLine($"El precio de la remera sin iva es de: ${remera}, y el precio de la remera con iva es de: ${remera * precioIva}");
            Console.WriteLine($"El precio del pantalón sin iva es de: ${pantalon}, y el precio del pantalón con iva es de: ${pantalon * precioIva}");
            Console.WriteLine($"El precio de la campera sin iva es de: ${campera}, y el precio de la campera con iva es de: ${campera * precioIva}");
            Console.ReadKey();
        }
    }
}
