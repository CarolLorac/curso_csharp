using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    //out e ref permite atribuir/alterar um valor q era de valor por referencia
    //(atribuicao por valor > atribuicao por referencia)
    //ref - 2 direções 
    //out - 1 direção
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 10;
            numero2 = numero2 + 20;
        }

        public static void Alterar( int numero)
        {
            numero = numero + 50;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine($"Ref: {a}");

            AlterarOut(out int b, out int c); //permite a função ter "duas saidas"
            Console.WriteLine($"Out:  {b},  {c}");

            int d = 10;
            Alterar(d);
            Console.WriteLine($"Sem referência (ref ou out): {d}"); 
        }
    }

    class OutroExemplo
    {
        static void PassagemPorValor(int a)
        {
            a = 10;
        }

        static void PassagemPorReferencia(ref int a)
        {
            a = 10;
        }

        public static void Executar()
        {
            int n = 5;
            PassagemPorValor(n);
            Console.WriteLine($"Passagem por valor: {n}"); //vai exibir 5
            PassagemPorReferencia(ref n);
            Console.WriteLine($"Passagem por referencia: {n}"); //vai exibir 10
        }
    }
}
