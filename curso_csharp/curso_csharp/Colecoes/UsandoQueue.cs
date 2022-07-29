using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Colecoes
{
    class UsandoQueue
    {
        //Queue => fila
        //O primeiro que chega é o primeiro que sai

        public static void Executar()
        {
            var fila = new Queue<string>(); //se não quiser definir um tipo de dado, é só usar Queue()

            fila.Enqueue("Vô Nelson");
            fila.Enqueue("Vó Maria");
            fila.Enqueue("Mãe");
            fila.Enqueue("Pai");
            fila.Enqueue("Ermã");
            fila.Enqueue("Eu");

            Console.WriteLine($"Quantidade de pessoas na fila: {fila.Count}");
            Console.WriteLine($"Primeira pessoa da fila: {fila.Peek()}");

            Console.WriteLine($"* Removendo primeira pessoa da fila *");
            fila.Dequeue();

            Console.WriteLine($"\nNova quantidade pessoas: {fila.Count}");

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
