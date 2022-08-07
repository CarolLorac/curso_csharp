using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.MetodosEFuncoes
{
    class Lambda
    {
        public static void Executar()
        {
            // Action sem parametros
            Action iniciarDia = () =>
            {
                Console.WriteLine("Bom dia!!");
            };
            iniciarDia();

            // Action com parametros
            Action<string> declarar = (nome) => Console.WriteLine($"{nome}, te amo!!");
            declarar("Silvane");

            // Func sem parametros
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                int num = random.Next(1, 7);
                return num;
            };
            Console.WriteLine(jogarDado());

            // Func com 1 parametro
            Func<int, string> conversorHexa = (numeroHexa) => numeroHexa.ToString("X");
            Console.WriteLine(conversorHexa(1920));

            // Func com +1 parametros
            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            {
                return String.Format($"{dia:D2}/{mes:D2}/{ano:D4}"); 
            };
            Console.WriteLine(formatarData(12,02,2004));
        }
    }
}
