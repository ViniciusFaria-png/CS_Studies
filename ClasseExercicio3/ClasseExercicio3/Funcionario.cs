using System;
using System.Globalization;

namespace ClasseExercicio3 {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            porcentagem /= 100;
            SalarioBruto = SalarioBruto * (1 + porcentagem);
        }

        public override string ToString() {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
