using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;

        public Aluno(string nome, int idade, double nota)
        {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }
    }

    class LINQ1 //com ele você consegue usar funções lambdas dentro de outras funções e fazer consultas igual no sql
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>()
            {
                new Aluno("Carol", 18, 9.5),
                new Aluno("Henrique", 40, 7),
                new Aluno("Silvane", 45, 8),
                new Aluno("Vanessa", 30, 10),
                new Aluno("Edipo", 33, 6)
            };

            Console.WriteLine("Chamada ======");
            var chamada = alunos.OrderBy(x => x.Nome).Select(x => x.Nome); //ordena e retorna somente o nome
            foreach(var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\nAprovados ===========");
            var aprovados = alunos.Where(x => x.Nota > 7) 
                .OrderBy(x => x.Nota); //vai retornar os alunos com nota maior que 7 ordenados por nota
            foreach(var aprovado in aprovados)
            {
                Console.WriteLine($"{aprovado.Nome} - {aprovado.Nota}");
            }

            Console.WriteLine("\nAprovados ===========");
            var alunosReprovados = from aluno in alunos
                                   where aluno.Nota <= 7
                                   select aluno;
            foreach(var alunoReprovado in alunosReprovados)
            {
                Console.WriteLine($"{alunoReprovado.Nome} - {alunoReprovado.Nota}");
            }

            Console.WriteLine("\nAprovados (por idade) =========");
            var alunosAprovados = 
                from aluno in alunos
                where aluno.Nota > 7
                orderby -aluno.Idade
                select aluno; //para mudar a ordem do orderby, só precisa colocar o sinal de negativo

            foreach(var alunoAprovado in alunosAprovados)
            {
                Console.WriteLine($"{alunoAprovado.Nome} - {alunoAprovado.Idade}");
            }

        }
    }
}
