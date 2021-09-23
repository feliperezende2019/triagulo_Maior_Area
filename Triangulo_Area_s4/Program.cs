using System;
using System.Globalization;
namespace Triangulo_Area_s4
{
    class Program
    {
        static void Main(string[] args)
        {
            // p = (x1 + x2 + x3) / 2; 
            // Formula de Heron areaX = Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));


            // Variables 
            double areaX, areaY;
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            // Recebendo dados
            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // Calculando usando a formula
            double p = (x.A + x.B + x.C) / 2;
            areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            // Verificando maior área.
            if (areaX > areaY)
                Console.WriteLine("Maior área: X");
            else
                Console.WriteLine("Maior área: Y");
        }
    }
}
