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
            /*Ingresar 2 notas de parciales de un alumno e informar si está aprobado, desaprobado o si debe recuperar el primer parcial o el segundo sabiendo que la nota de aprobación es 4 y se
            deben aprobar los 2 parciales.*/

            const int aprobar = 4;

            Console.Write("Ingrese la nota uno: ");
            int notaUno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la nota dos: ");
            int notaDos = Convert.ToInt32(Console.ReadLine());

            if(notaUno >= aprobar && notaDos >= aprobar)
            {
                Console.WriteLine("Aprobaste la cursada!!");

            }else if(notaUno >= aprobar && notaDos <= aprobar)
            {
                Console.WriteLine("Tenés que recuperar el segundo parcial!!");
            
            }else if(notaUno <= aprobar && notaDos >= aprobar)
            {
                Console.WriteLine("Tenés que recuperar el primer parcial!!");
            } 

             else if(notaUno < aprobar && notaDos < aprobar)
                {
                    Console.WriteLine("Desaprobaste la materia!!");
                }
            Console.ReadKey();
            }
        }
    }

