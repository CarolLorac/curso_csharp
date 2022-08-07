using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);
    //delegate tipo_retorno Nome (parametros);

    class LambdaDelegate
    {
        public static void Executar()
        {
            Operacao som = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine($"Somar: {som(5, 5)}");
            Console.WriteLine($"Subtrair: {sub(5, 5)}");
            Console.WriteLine($"Multiplicar: {mult(5, 5)}");
        }
    }
}
