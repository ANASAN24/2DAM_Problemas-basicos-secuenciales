using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configura la codificación UTF-8 para mostrar correctamente caracteres especiales como el símbolo del euro.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const double PRECIO_HAMBURGUESA = 4.50;
            const double PRECIO_PAPAS = 2.25;
            const double PRECIO_BEBIDA = 1.35;

            int hamburguesas, papas, bebidas;
            double total;

            Console.Write("Cantidad de hamburguesas: ");
            hamburguesas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad de papas: ");
            papas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad de bebidas: ");
            bebidas = Convert.ToInt32(Console.ReadLine());

            total = hamburguesas * PRECIO_HAMBURGUESA
                  + papas * PRECIO_PAPAS
                  + bebidas * PRECIO_BEBIDA;

            Console.WriteLine($"Cantidad a pagar: {total:F2}€");

            Console.ReadLine();
        }
    }
}