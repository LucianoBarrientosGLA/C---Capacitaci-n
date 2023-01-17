using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Desarrollar el código que permita a una persona ingresar como máximo tres veces su contraseña.
             ● En caso de ingreso correcto deberá exhibirse la leyenda “Bienvenido!!”, caso contrario se mostrará “tres veces fallidas”.
             ● Indicar cuantas posibilidades de ingresar el código le queda. Por ejemplo, si tiene 2 posibilidades, informar "Tiene dos chances
               !" y si le queda una última oportunidad "Atención!! Ultima oportunidad!"
             */

            //registro
            Console.Write("Ingrese clave para registrarse: ");
            string claveRegistro = Console.ReadLine();

            //ingreso
            Console.Write("\nIngrese clave para ingresar: ");
            string claveingreso = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                if(claveingreso == claveRegistro)
                {
                  Console.WriteLine("Bienvenido");
                    i = 4;

                }
                else
                {
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Te quedan dos intentos!");
                            Console.Write("ingrese nuevamente su clave: ");
                            claveingreso = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Atención, ultimo intento!");
                            Console.Write("ingrese nuevamente su clave: ");
                            claveingreso = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("Fallaste los 3 intentos!");
                            break;
                    }
                }
            }
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();  
        } 
       
    }
}
