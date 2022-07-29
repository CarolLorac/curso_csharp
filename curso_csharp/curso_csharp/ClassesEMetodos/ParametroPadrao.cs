using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a = 2, int b = 1) // os paramêtros assumem os valores definidos se caso nenhum valor for passado na utilização
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(10, 20)); //10 + 20 = 30 
            Console.WriteLine(Somar(15)); //15 + 1 (valor padrao b) = 16
            Console.WriteLine(Somar(b: 8)); //2 (valor padrao a) + 8 = 10
            Console.WriteLine(Somar()); //2 (valor padrao a) + 1 (valor padrao b) = 3
        }
    }
}
