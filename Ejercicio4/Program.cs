using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado, perimetro;

            Console.Write("Introduce el lado del cuadrado: ");
            lado = Convert.ToDouble(Console.ReadLine());

            perimetro = lado * 4;

            Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");

            Console.ReadLine();
        }
    }
}
