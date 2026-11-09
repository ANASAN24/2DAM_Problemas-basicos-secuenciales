using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double numero3; 
            double numero4;
            double suma; 
            double promedio;

            Console.Write("Introduce el primer número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el tercer número: ");
            numero3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el cuarto número: ");
            numero4 = Convert.ToDouble(Console.ReadLine());

            suma = numero1 + numero2 + numero3 + numero4;
            promedio = suma / 4;

            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"El promedio es: {promedio}");

            Console.ReadLine();
        }
    }
}
