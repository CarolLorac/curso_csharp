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
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2002))
            {
                Console.WriteLine($"2002: {filmes[2002]}");
                Console.WriteLine($"2002: {filmes.GetValueOrDefault(2002)}");
            }

            Console.WriteLine(filmes.ContainsValue("Esposa de mentirinha")); //verifica se tem o filme (value) esposa de mentirinha

            filmes.TryGetValue(2006, out string filme2006); //pega o value (filme) a partir da chave (ano) e adiciona na variavel filme2006
            Console.WriteLine($"Filme: {filme2006}");

            Console.Write("\n");
            foreach (var filme in filmes.Values)
            {
                Console.WriteLine(filme);
            }

            Console.Write("\n");
            foreach (var ano in filmes.Keys)
            {
                Console.WriteLine(ano.ToString());
            }

            Console.Write("\n");
            foreach (var filme in filmes)
            {
                Console.WriteLine($"O filme {filme.Value} foi lançado em {filme.Key}");
            }

            Console.Write("\n");
            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"O filme {filme.Value} foi lançado em {filme.Key}");
            }
        }
    }
}
