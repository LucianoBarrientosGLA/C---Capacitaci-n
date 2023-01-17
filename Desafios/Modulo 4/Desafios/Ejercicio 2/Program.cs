using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dado un vector del 0 al 11 con la facturación correspondiente a todo un año, informar la
               facturación por trimestre. Para esto,armar un vector de 4 posiciones, donde cada posición
               contenga la facturación de cada trimestre.
             * 
             */
            int[] facturacion = { 20, 30, 50, 40, 90, 80, 15, 65, 25, 100, 120, 45 };

            int suma = 0;

            List<int> trimestre = new List<int>();

            for (int i = 1; i <= 12; i++)
            {
                if (i % 3 == 0)
                {
                    suma += facturacion[i - 1];
                    trimestre.Add(suma);
                    suma = 0;
                }
                else
                {
                    suma += facturacion[i - 1];
                }
            }
            for (int i = 0; i < trimestre.Count; i++)
            {
                Console.WriteLine(trimestre[i]);
            }


            Console.ReadKey();
        } 
      } 
   }


