using System;
using System.Globalization;

namespace Course {
    class Ex2 {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha): ");

            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
            Console.WriteLine(quantidadeQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}


