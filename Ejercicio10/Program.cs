using System;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            bool resultado;

            Console.Write("Introduce una cadena de texto para ver si empieza por www: ");
            texto = Console.ReadLine();

            resultado = texto.StartsWith("www");

            if (resultado == true)
            {
                Console.WriteLine("La cadena empieza por www");
            }
            else
            {
                Console.WriteLine("La cadena no empieza por www");
            }
        }
    }
}
