using System;
using System.Collections.Generic;
using System.IO;
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
             * Copiar el contenido del vector origen al vector destino, dejando en este último los valores
               invertidos respecto del vector origen. Utilizar estructura de control de flujo repetitiva, y luego
               informar el índice y los valores del nuevo vector
             */

            //Declaración de Vectores.
            int[] vectorOrigen = { 1002, 104, 309, 500 };

            int[] vectorDestino = new int[4];


            //Muestro el Vector Origen.
            Console.WriteLine("Vector Origen");

            for (int i = 0; i < vectorOrigen.Length; i++)
            {
                Console.WriteLine(vectorOrigen[i]);
            }

            //Muestro el Vector Destino.

            Console.WriteLine("Vector Destino");
            for (int i = 0; i < vectorOrigen.Length; i++)
            {
                vectorDestino[i] = vectorOrigen[vectorOrigen.Length - 1 - i];
                Console.WriteLine(vectorDestino[i]);    
            }


            Console.ReadKey();
            
        }
    }
}
