using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new ProdutoModel("Caneta", 1.99);
            var p2 = new ProdutoModel("Caneta", 1.99);
            var p3 = p2;

            Console.WriteLine(p1 == p2); //Compara endereço de memória e não o valor
            Console.WriteLine(p3 == p2); //Compara o valor

            Console.WriteLine(p1.Equals(p2)); //Compara o valor

        }
    }
}
