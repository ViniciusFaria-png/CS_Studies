using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o código 1-Alcool / 2-Gasolina / 3-Diesel / 4-Fim");
            int value = 0;
            int Alcool = 0, Gasolina = 0, Diesel = 0;
            while(value != 4) {
                value = int.Parse(Console.ReadLine());
                if (value == 1) {
                    Alcool++;
                }
                else if (value == 2) {
                    Gasolina++; 
                }
                else if(value == 3) {
                    Diesel++;
                }
                else {
                    Console.WriteLine("Código inválido, digite novamente!!");
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {Alcool}");
            Console.WriteLine($"Gasolina: {Gasolina}");
            Console.WriteLine($"Diesel: {Diesel}");

        }
    }
}
