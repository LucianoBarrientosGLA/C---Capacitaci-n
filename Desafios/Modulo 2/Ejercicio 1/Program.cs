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
            //Ingresar una nota de un alumno, e informar si está aprobado, si recupera o si promociona la materia.
            //------Datos------
            //Se aprueba con 4 y se promociona con 7.

            

            Console.Write("Ingrese la nota del alumno: ");
            int notaAlumno = Convert.ToInt32(Console.ReadLine());

            if(notaAlumno >= 4 && notaAlumno < 7)
            {
                Console.WriteLine("Aprobaste la cursada!!!");
               
            }
            else if(notaAlumno >= 7 && notaAlumno <= 10)
            {
                Console.WriteLine("Felicidades, promocionaste la cursada!!!");
            }
            else
            {
                Console.WriteLine("Tenés que recuperar la matería!!");
            }

            Console.ReadKey();
            }
         

        }
    }

