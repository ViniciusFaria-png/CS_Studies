using System;
using System.Globalization;

namespace ClasseExercicio3 {
    class Program {
        static void Main(string[] args) {
            Funcionario x = new Funcionario();
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + x);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + x);

        }
    }
}
