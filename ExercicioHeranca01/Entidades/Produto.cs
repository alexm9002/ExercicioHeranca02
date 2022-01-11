using System.Globalization;
namespace ExercicioHeranca02.Entidades {
    class Produto {

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco) {
            this.Nome = nome;
            this.Preco = preco;
        }

        public virtual string EtiquetadePreco() {
            return Nome
                + " R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
