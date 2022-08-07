using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double x, double y);

        delegate void ImprimirSoma(double x, double y);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double x, double y)
        {
            Console.WriteLine(x + y);
        }

        public static void Executar()
        {
            //Delegate com método
            Soma somar = MinhaSoma;
            Console.WriteLine(somar(5, 5));

            ImprimirSoma imprimir = MeuImprimirSoma;
            imprimir(10, 10);

            //Lambda com método
            Func<double, double, double> som = MinhaSoma;
            Console.WriteLine(som(15, 15));

            Action<double, double> imp = MeuImprimirSoma;
            imp(20, 20);

            //Delegate com lambda
            Soma s = (x, y) => x + y;
            Console.WriteLine(s(25, 25));

            ImprimirSoma i = (x, y) => Console.WriteLine(x + y);
            i(30, 30);
        }
    }
}
