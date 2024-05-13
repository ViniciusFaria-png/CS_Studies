using System;
using System.Globalization;

namespace MembrosEstaticosEx1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotacao do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares voce vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.ConverteMoeda(cotacao, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
