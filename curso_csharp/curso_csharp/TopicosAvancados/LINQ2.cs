using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>()
            {
                new Aluno("Carol", 18, 9.5),
                new Aluno("Henrique", 40, 8),
                new Aluno("Silvane", 45, 7),
                new Aluno("Vanessa", 30, 10),
                new Aluno("Carol", 67, 5),
                new Aluno("Edipo", 33, 6),
            };

            Console.WriteLine("Alunos e notas");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"{aluno.Nome} - {aluno.Nota}");
            }

            var vanessa = alunos.Single(x => x.Nome.Equals("Vanessa")); //pega o primeiro
            Console.WriteLine($"{vanessa.Nome}\n");

            var fulano = alunos.SingleOrDefault(x => x.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno não encontrado!!");
            }

            var silvane = alunos.First(x => x.Nome.Equals("Silvane"));
            Console.WriteLine(silvane.Nome);

            var ciclano = alunos.FirstOrDefault(x => x.Nome.Equals("Ciclano")); //a diferença entre esse e o firts é que esse retorna nulo quando não encontra o nome e o outro dá erro
            if(ciclano == null)
            {
                Console.WriteLine("Aluno não encontrado!!");
            }

            var ultimaCarol = alunos.LastOrDefault(x => x.Nome.Equals("Carol")); //pega o último
            Console.WriteLine($"{ultimaCarol.Nome} - {ultimaCarol.Idade} - {ultimaCarol.Nota}");

            var exemploSkip = alunos.Skip(2).Take(3); //pega os 3 alunos a partir dos 2 primeiros
            Console.WriteLine("\nExemplo skip: ");
            foreach(var skip in exemploSkip)
            {
                Console.WriteLine(skip.Nome);
            }

            var maiorNota = alunos.Max(x => x.Nota); 
            Console.WriteLine($"\nMaior nota: {maiorNota}");

            var menorNota = alunos.Min(x => x.Nota);
            Console.WriteLine($"Maior nota: {menorNota}");

            var somatorioNotas = alunos.Sum(x => x.Nota);
            Console.WriteLine($"Total notas: {somatorioNotas}");

            var mediaTurma = alunos.Average(x => x.Nota);
            Console.WriteLine($"Media turma: {mediaTurma.ToString("0.00")}");

            var mediaAprovados = alunos.Where(x => x.Nota > 7).Average(x => x.Nota); //faz a media da nota dos alunos com nota maior que 7
            Console.WriteLine($"Media aprovados: {mediaAprovados.ToString("0.00")}");

        }
    }
}
