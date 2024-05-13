using System;
using System.Globalization;

namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            char afirmacao = char.Parse(Console.ReadLine());
            if (afirmacao == 's' || afirmacao == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numConta, nome, depInicial);
            }

            else {
                conta = new ContaBancaria(numConta, nome);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(value);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(value);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

        }
    }
}
