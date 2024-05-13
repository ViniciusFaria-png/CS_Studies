using System;
using System.Globalization;

namespace ExercicioProduto {
    internal class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidadade { get; private set; }

    public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) : this() {
            _nome = nome;
            Preco = preco;
            Quantidadade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return Quantidadade * Preco;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidadade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidadade -= quantidade;
        }

        public override string ToString() {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidadade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
