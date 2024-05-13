using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0.00 && salario <= 2000.00 ) {
                Console.WriteLine("Isento");
            }

            else if (salario >= 2000.01 && salario <= 3000.00) {
                double novoValor = salario - 2000;
                novoValor = (8.0 / 100) * novoValor;
                Console.WriteLine("R$ " + novoValor.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (salario >= 3000.01 && salario <= 4500.00){
                double novoValor = salario - 3000;
                novoValor = (18.0 / 100) * novoValor;
                novoValor += 80;
                Console.WriteLine("R$ " + novoValor.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if(salario > 4500.00) {
                double novoValor = salario - 4500;
                novoValor = (28.0 / 100) * novoValor;
                novoValor += 350;
                Console.WriteLine("R$ " + novoValor.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

