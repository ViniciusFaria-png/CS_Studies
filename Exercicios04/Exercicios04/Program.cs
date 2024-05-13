using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um valor: ");
            int value = int.Parse(Console.ReadLine());
            for(int i = 1; i <= value; i++) {
                Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
            }
        }
    }
}
