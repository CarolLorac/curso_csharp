using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar (int a, int b)
        {
            return a + b;
        }

        public int Subtrair (int a, int b)
        {
            return a - b;
        }

        public double Multiplicar (double a, int b)
        {
            return a * b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this; //como ele entende que tem que retornar o memória???
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadora = new CalculadoraComum();

            Console.WriteLine("Calculadora comum: ");
            Console.WriteLine(calculadora.Somar(2, 10));
            Console.WriteLine(calculadora.Subtrair(8, 7));
            Console.WriteLine(calculadora.Multiplicar(1.2, 5));


            var calculadoraCadeia = new CalculadoraCadeia(); 

            Console.WriteLine("\nCalculadora cadeia: ");
            calculadoraCadeia.Somar(10).Multiplicar(3).Imprimir().Limpar().Imprimir();
            Console.WriteLine(calculadoraCadeia.Somar(5).Somar(13).Resultado());
        }
    }
}
