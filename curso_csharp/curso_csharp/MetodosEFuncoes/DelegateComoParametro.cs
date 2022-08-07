using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.MetodosEFuncoes
{
    class DelegateComoParametro
    {
        delegate int Operacao(int x, int y);

        static int Somar(int x, int y)
        {
            return x + y;
        }

        static void Calculadora(Operacao op, int x, int y) //delegate como parametro
        {
            var resultado = op(x, y);
            Console.WriteLine($"Resultado {resultado}");
        }

        public static void Executar()
        {
            Operacao subtrair = (x, y) => x - y;
            Calculadora(subtrair, 10, 5);

            Calculadora(Somar, 15, 20);
        }
    }
}
