using curso_csharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.TopicosAvancados
{
    public class Caixa<T> // é possivel atribuir um tipo de dado ao instanciar a classe ou ao herdar
    {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor)
        {
            return new Random().Next(0,2) == 0 ? Coisa : valor;  
        }

        public T GetValor()
        {
            return valorPrivado;
        }
    }

    public class CaixaInt : Caixa<int> //tipo int
    {
        CaixaInt() : base(0)
        {
        }
    }

    public class CaixaProduto : Caixa<Produto> //tipo Produto
    {
        public CaixaProduto() : base(new Produto())
        {
        }
    }

    class ExemploGenerics
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(22));
            Console.WriteLine(caixa1.GetType().Name);

            var caixa2 = new Caixa<string>("Praia, mar e sol");
            Console.WriteLine(caixa2.metodoGenerico("Chuva e frio"));
            Console.WriteLine(caixa2.GetType().Name);

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
