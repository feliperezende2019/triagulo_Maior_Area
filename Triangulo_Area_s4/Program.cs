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


            // Variaveis
            double xA, xB, xC, yA, yB, yC;
            double areaX, areaY;

            // Recebendo dados
            Console.WriteLine("Entre com as medidas do triangulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // Calculando usando a formula
            double p = (xA + xB + xC) / 2;
            areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
