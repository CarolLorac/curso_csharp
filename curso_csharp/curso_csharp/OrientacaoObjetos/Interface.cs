using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.OrientacaoObjetos
{
    interface OperacoesBinarias
    {
        public int Operacao(int a, int b);
    }

    class Soma : OperacoesBinarias
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    class Multiplicacao : OperacoesBinarias
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacoesBinarias> operacoes = new List<OperacoesBinarias>
        {
            new Soma(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach(var op in operacoes)
            {
                resultado += $"O resultado de {op.GetType().Name} ({a} e {b}) é {op.Operacao(a, b)}.\n";
            }

            return resultado;
        }
    }

    class Interface
    {
        public static void Executar()
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.ExecutarOperacoes(20, 5));
        }
    }
}
