using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticosEx1 {
    internal class ConversorDeMoeda {
        public static double Iof = 6.0;
        public static double ConverteMoeda(double quantitade, double cotacao) {
            double total = cotacao * quantitade;
            return total + total * Iof / 100.0;
        }
    }
}
