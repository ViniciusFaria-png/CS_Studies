using System;
using System.Globalization;

namespace MembrosEstaticos {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double circ = Calculadaora.Circunferencia(raio);
            double volume = Calculadaora.Volume(raio);

            Console.WriteLine("Circunferencia " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi " + Calculadaora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        
    }
}