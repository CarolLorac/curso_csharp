using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.MetodosEFuncoes
{
    delegate string StringOperacao (string palavra);

    class DelegateComFuncaoAnonima
    {
        public static void Executar()
        {
            StringOperacao reverterString = delegate (string palavra)
            {
                char[] letras = palavra.ToCharArray();
                Array.Reverse(letras);
                return new string(letras);
            };

            Console.WriteLine(reverterString("C# é show!!"));
        }
    }
}
