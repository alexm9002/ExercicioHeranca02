using System;
using System.Globalization;
using System.Collections.Generic;
namespace ExercicioHeranca02.Entidades {
    class ProdutoUsado : Produto {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base (nome, preco) {
            this.DataFabricacao = dataFabricacao;
        }
                               //Usar variável da superclasse
        public override string EtiquetadePreco() {
            return Nome
            + " (Usado) R$ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + " (Data de Fabricação: "
            + DataFabricacao.ToString("dd/MM/yyyy")
            + ")";
        }
    }
}
