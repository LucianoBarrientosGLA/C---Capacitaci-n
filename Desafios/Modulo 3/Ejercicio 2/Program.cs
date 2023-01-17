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
            /*
             * Una persona desea invertir $1000 en un banco, el cual le otorga un 3% de interés mensual.
               ¿En cuantos meses conseguirá $1200, si reinvierte cada mes todo su dinero?.
             */

            double dineroInicial = 1000;
            double interesMensual = 1.03;
            int contador = 0;

            List<string> meses = new List<string>() { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            do { 
               Console.WriteLine($"Dinero: {dineroInicial} en el mes: {meses[contador]}");
               dineroInicial *= interesMensual;
                contador++;           
            
            } while(dineroInicial < 1200);
            Console.WriteLine($"\nDinero: {dineroInicial} en el mes: {meses[contador]}");
            Console.WriteLine("Llegaste a 1200$!!!");
            Console.ReadKey();
        }
    }
}
