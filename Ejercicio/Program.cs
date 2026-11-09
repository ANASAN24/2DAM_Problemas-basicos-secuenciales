using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double parcial1;
            double parcial2;
            double examen;
            double trabajo;
            double promedioParciales;
            double notaFinal;

            Console.Write("Introduce la nota del primer parcial: ");
            parcial1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la nota del segundo parcial: ");
            parcial2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la nota del examen: ");
            examen = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la nota del trabajo final: ");
            trabajo = Convert.ToDouble(Console.ReadLine());

            promedioParciales = (parcial1 + parcial2) / 2;

            notaFinal = promedioParciales * 0.50
                      + examen * 0.30
                      + trabajo * 0.20;

            Console.WriteLine($"La nota final del módulo es: {notaFinal:F2}");

            Console.ReadLine();
        }
    }
}
