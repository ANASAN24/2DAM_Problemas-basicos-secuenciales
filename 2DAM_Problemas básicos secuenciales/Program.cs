using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Introduce el primer número:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La suma es {numero1 + numero2}");
            Console.WriteLine($"La resta es: {numero1} - {numero2} = { numero1 - numero2}");
            Console.WriteLine($"La multiplicación es: {numero1 * numero2}");
            Console.WriteLine($"La división es: {numero1 / numero2}");
            Console.WriteLine($"El módulo es: {numero1 % numero2}");

            Console.ReadLine();
        }
    }
}