using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Colecoes
{
    class UsandoStack
    {
        public static void Executar()
        {
            var pilha = new Stack(); //os métodos do Stack vão sempre interagir com o ultimo item da lista

            pilha.Push("Carol");
            pilha.Push(18);
            pilha.Push("Engenharia da computação");
            pilha.Push(1.61);
            
            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}  ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");
            Console.WriteLine($"Nova quantidade de items: {pilha.Count}");

            Console.WriteLine($"\nPeek: {pilha.Peek()}");
        }
    }
}
