using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.TopicosAvancados
{
    class ExemploDynamics
    {
        public static void Executar()
        {
            dynamic teste = "Caroline";
            teste = 3;

            teste++;
            Console.WriteLine(teste);

            dynamic aluno = new System.Dynamic.ExpandoObject(); //cria objeto que poe ser "expandido"
            aluno.nome = "Elo";
            aluno.idade = 18;
            aluno.altura = 1.55;

            Console.WriteLine($"{aluno.nome} {aluno.idade} {aluno.altura}");
        }
    }
}
