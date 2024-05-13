using System;
using System.Globalization;

namespace AulaStructs {
    class Program {
        static void Main(string[] args) {

            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serao alugados? ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for(int i = 0; i < n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i+1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numQuarto = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect[numQuarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++) {
                if (vect[i] != null ) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}