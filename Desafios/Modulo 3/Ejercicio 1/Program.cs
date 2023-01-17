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
            /* 
             * Una persona desea invertir $1000 en un banco, el cual le otorga un 2% de interés mensual.
               ¿Cuál será la cantidad de dinero que esta persona tendrá al cabo de un año?.
               En el primer mes tendrá acumulado $1000 más $20 de interés ( 2% de 1000 ). En el segundo mes
               se le sumará un 2% a la base de $1020 del mes anterior y así sucesivamente. 
             */

            double dineroInvertido = 1000;
            double interesMensual = 1.02;
            int cantidadMeses = 12;

            List<string> meses = new List<string>() {"Enero" , "Febrero" , "Marzo" , "Abril" , "Mayo" , "Junio" , "Julio" , "Agosto" , "Septiembre" , "Octubre" , "Noviembre" , "Diciembre" };
      
            for (int i = 0; i < cantidadMeses; i++)
            {
                Console.WriteLine($"Mes: {meses[i]} \n Dinero: {dineroInvertido} \n");
                dineroInvertido *= interesMensual;
            }
            Console.ReadKey();

        }
    }
}

