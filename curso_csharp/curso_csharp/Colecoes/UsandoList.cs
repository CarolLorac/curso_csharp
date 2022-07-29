using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Colecoes
{

    class UsandoList
    {
        public static void Executar()
        {
            var livro = new ProdutoModel("Marley e Eu", 40.0);

            var carrinhoCompra = new List<ProdutoModel>(); 
            carrinhoCompra.Add(livro);

            var combo = new List<ProdutoModel>
            {
                new ProdutoModel("Pipoca", 5.50),
                new ProdutoModel("Coca 2L", 8),
                new ProdutoModel("Brigadeiro", 15.90)
            };

            carrinhoCompra.AddRange(combo); 
            carrinhoCompra.RemoveAt(2); 

            foreach(var item in carrinhoCompra)
            {
                Console.Write(carrinhoCompra.IndexOf(item)); 
                Console.WriteLine($" {item.Nome}  R${item.Valor.ToString("0.00")}");
            }

            carrinhoCompra.Add(livro); // List permite ter valores repetidos
        }
    }
}
