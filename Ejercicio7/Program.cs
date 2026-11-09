using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configura la codificación UTF-8 para mostrar correctamente el símbolo del euro.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double precio;
            double coste;
            int cantidad;

            Console.Write("Introduce el precio del artículo: ");
            precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            coste = precio * cantidad;

            // F2 -> muestra el resultado con dos decimales.
            Console.WriteLine($"El coste total es: {coste:F2}€");

            Console.ReadLine();
        }
    }
}