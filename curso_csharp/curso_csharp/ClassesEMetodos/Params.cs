using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
     class Params
     {
        //params - representa um conjunto de parâmetros variaveis (palavra reservada do c#)

        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Olá {pessoa}");
            }
        }

        public static void Valores(params object[] valores)
        {
            foreach(var valor in valores)
            {
                Console.WriteLine(valor);
            }
        }

        public static void Executar()
        {
            Recepcionar("Carol", "Camila", "Leo", "Décio");

            object[] lista = { 1, "a", 3.5, "carol" };
            Valores(lista);
        }
     }
}
