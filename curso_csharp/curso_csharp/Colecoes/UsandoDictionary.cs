using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Colecoes
{
    class UsandoDictionary
    {
        public static void Executar()
        {
            //parte do chave não aceita valores repetidos, na parte do valor aceita
            //Dictionary<chave, valor>

            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríves");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2002))
            {
                Console.WriteLine($"2002: {filmes[2002]}");
                Console.WriteLine($"2002: {filmes.GetValueOrDefault(2002)}");
            }

            Console.WriteLine(filmes.ContainsValue("Os Incríveis"));

        }
    }
}
