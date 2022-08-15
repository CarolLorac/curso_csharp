using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Valor;
        public static double Desconto = 0.1; // valor da variavel fica fixo
        //não é possível herdar uma propriedade com static

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public Produto() { }

        public double CalcularDesconto()
        {
            return Valor - Valor * Desconto;
        }
    }

    class AtributosEstaticos
    {
        public static void Executar()
        {
            Produto produto = new Produto("Borracha", 5);
            Console.WriteLine(produto.CalcularDesconto());

            Produto.Desconto = 0.9; //aqui, altera o valor do Desconto diretamente na classe - não é possível alterar em só uma instância/objeto

            Console.WriteLine(produto.CalcularDesconto());
        }
    }
}
