using System;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double socio1;
            double socio2;
            double socio3;

            double total;
            double porcentaje1;
            double porcentaje2; 
            double porcentaje3;

            Console.Write("Introduce la aportación del primer socio: ");
            socio1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la aportación del segundo socio: ");
            socio2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la aportación del tercer socio: ");
            socio3 = Convert.ToDouble(Console.ReadLine());

            total = socio1 + socio2 + socio3;

            porcentaje1 = socio1 / total * 100;
            porcentaje2 = socio2 / total * 100;
            porcentaje3 = socio3 / total * 100;

            Console.WriteLine($"El primer socio aporta el {porcentaje1:F2}%");
            Console.WriteLine($"El segundo socio aporta el {porcentaje2:F2}%");
            Console.WriteLine($"El tercer socio aporta el {porcentaje3:F2}%");

            Console.ReadLine();
        }
    }
}
