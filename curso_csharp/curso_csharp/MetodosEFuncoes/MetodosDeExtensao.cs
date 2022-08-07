using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro //o método criado pode ser usado em qualquer outra parte do código, como uma nova funcionalidade
    {
        public static string ToHexadecimal(this int num) //this + tipo parametro = extende o método para o tipo
        {
            return num.ToString("X");
        }
    }

    class MetodosDeExtensao 
    {
        public static void Executar()
        {
            int numero = 650;
            Console.WriteLine(numero.ToHexadecimal());
        }
    }
}
