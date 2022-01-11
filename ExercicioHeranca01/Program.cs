using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioHeranca02.Entidades;

namespace ExercicioHeranca01 {

    class Program {

        static void Main(string[] args) {

            List<Produto> Lista = new List<Produto>();

            Console.Write("Entre com o número de Produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine("Dados do Produto #" + i + ":");
                Console.Write("Mercadoria, Nacional, Usada ou Importada? (N/U/I): ");
                char t = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (t == 'n' || t == 'N') {
                    Lista.Add(new Produto(nome, preco));
                }
                else if (t == 'u' || t == 'U') {
                    Console.Write("Entre com a data de fabricação: ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    Lista.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }
                else {
                    Console.Write("Entre com a Taxa de Alfândega: ");
                    double taxadeAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Lista.Add(new ProtutoImportado(nome, preco, taxadeAlfandega));
                }
                Console.WriteLine("-------------");
                Console.WriteLine("Etiquetas de Preço:");
            }
            foreach (Produto prod in Lista) {
                Console.WriteLine(prod.EtiquetadePreco());
            }
        }
    }
}