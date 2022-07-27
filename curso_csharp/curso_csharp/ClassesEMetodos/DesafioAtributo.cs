using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            // Acessar variavel 'a' dentro do método Executar
            //obs: por o método Executar ser static, não é possível acessar a varável 'a' diretamente pq ela "pertence" à instância e o método static nao pode ser instanciado

            DesafioAtributo desafio = new DesafioAtributo();

            Console.WriteLine(desafio.a);
        }
    }
}
