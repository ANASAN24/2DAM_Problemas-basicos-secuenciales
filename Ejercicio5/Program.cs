using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3, numero4;
            double suma, producto;

            Console.Write("Introduce el primer número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el tercer número: ");
            numero3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el cuarto número: ");
            numero4 = Convert.ToDouble(Console.ReadLine());

            suma = numero1 + numero2;
            producto = numero3 * numero4;

            Console.WriteLine($"La suma de los dos primeros números es: {suma}");
            Console.WriteLine($"El producto de los dos últimos números es: {producto}");

            Console.ReadLine();
        }
    }
}
