using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Introduce un número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"El valor absoluto es: {Math.Abs(numero)}");
            Console.WriteLine($"El cubo es: {Math.Pow(numero, 3)}");
            Console.WriteLine($"La raíz cuadrada es: {Math.Sqrt(numero)}");
            Console.WriteLine($"El seno es: {Math.Sin(numero)}");
            Console.WriteLine($"El coseno es: {Math.Cos(numero)}");
            Console.WriteLine($"El máximo es: {Math.Max(numero, 10)}");
            Console.WriteLine($"El mínimo es: {Math.Min(numero, 10)}");

            Console.ReadLine();
        }
    }
}
