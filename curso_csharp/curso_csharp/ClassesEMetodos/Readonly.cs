using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    class Pessoa
    {
        public readonly double Altura = 1.61;
        public string Nome;
    }

    class Readonly
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa();

            //pessoa.Altura = 1.90; não é possível alterar pq é readonly
            pessoa.Nome = "Carol";

            Console.WriteLine($"A altura de {pessoa.Nome} é {pessoa.Altura}");
        }
    }
}
