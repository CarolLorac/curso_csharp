using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Colecoes
{
    class UsandoSet
    {
        //Set é um conjunto
        //1. Não é indexado - não consegue acessar o dado através do index
        //2. Não aceita valores repetidos
        public static void Executar()
        {
            var livro = new ProdutoModel("Marley e Eu", 40.0);

            var carrinhoCompra = new HashSet<ProdutoModel>(); 
            carrinhoCompra.Add(livro);

            var combo = new HashSet<ProdutoModel>
            {
                new ProdutoModel("Pipoca", 5.50),
                new ProdutoModel("Coca 2L", 8),
                new ProdutoModel("Brigadeiro", 15.90)
            };

            carrinhoCompra.UnionWith(combo); 
            //carrinhoCompra.RemoveAt(2); SET NÃO ACEITA

            foreach (var item in carrinhoCompra)
            {
                //Console.Write(carrinhoCompra.IndexOf(item)); SET NÃO ACEITA
                Console.WriteLine($" {item.Nome}  R${item.Valor.ToString("0.00")}");
            }
        }
    }
}
