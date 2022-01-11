using System.Globalization;
namespace ExercicioHeranca02.Entidades {
    class ProtutoImportado : Produto {
        public double TaxadeAlfandega { get; set; }

        public ProtutoImportado(string Nome, double Preco, double taxadeAlfandega) : base(Nome, Preco) {
            this.TaxadeAlfandega = taxadeAlfandega;
        }

        public double PrecoTotal() {
            return Preco + TaxadeAlfandega;
        }

        public override string EtiquetadePreco() {
            return Nome
            + " R$ "
            + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
            + " (Taxa de Alfândega: R$ "
            + TaxadeAlfandega.ToString("F2", CultureInfo.InvariantCulture)
            + ")";
        }

    }
}
