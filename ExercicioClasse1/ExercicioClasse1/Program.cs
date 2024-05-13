using System;
using System.Globalization;

namespace ExercicioClasse1 {
    class Program {
        static void Main(string[] args) {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite o Nome, Idade e Salario da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o Nome, Idade e Salario da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double salarioMedio = (p1.Salario + p2.Salario) / 2;

            if (p1.Idade > p2.Idade) Console.WriteLine($"Pessoa mais velha: {p1.Nome}");

            else Console.WriteLine($"Pessoa mais velha: {p2.Nome}");

            Console.WriteLine("Salário médio é: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
