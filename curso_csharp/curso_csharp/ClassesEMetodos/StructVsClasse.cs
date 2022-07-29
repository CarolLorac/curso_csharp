using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    //A diferença entre atribuição por valor e por referencia é que a atribuição por valor só se
    //refere a um valor e a por referência se refere a um local na memória, ou seja, independendte se valor que mudar, os atributos terão o mesmo valor
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse //A diferença entre os dois é o tipo de atribuição de cada, no struct a atribuição é por valor e na class e por referencia
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3};
            SPonto copiaPonto1 = ponto1; //ATRIBUIÇÃO POR VALOR
            ponto1.X = 5;

            CPonto ponto2 = new CPonto { X = 2, Y = 4};
            CPonto copiaPonto2 = ponto2; //ATRIBUIÇÃO POR REFERÊNCIA - as duas variaveis vão apontar para o mesmo local da memória
            ponto2.X = 7;
            
            Console.WriteLine("Ponto 1");
            Console.WriteLine($"X: {ponto1.X}"); //5
            Console.WriteLine($"X: {copiaPonto1.X}"); //1
            
            Console.WriteLine("Ponto 2");
            Console.WriteLine($"X: {ponto2.X}"); //7
            Console.WriteLine($"X: {copiaPonto2.X}"); //7

        }
    }
}
