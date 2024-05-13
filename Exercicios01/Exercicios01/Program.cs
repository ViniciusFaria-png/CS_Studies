using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Exercicio Nivelamento");
            string[] vect = Console.ReadLine().Split(' ');

            double A = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vect[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vect[2], CultureInfo.InvariantCulture);


            double trianguloArea = (A * C) / 2;
            double circuloArea = Math.Pow(C, 2) * 3.14159;
            double trapezioArea = ((A + B) * C)/2;
            double quadradoArea = Math.Pow(B, 2);
            double retanguloArea = A * B;

            Console.WriteLine("TRIANGULO: " + trianguloArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circuloArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezioArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadradoArea.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retanguloArea.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

