using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void FormatarData(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano); //D2 indica 2 casas decimais
        }

        public static void Executar()
        {
            FormatarData(mes: 2, dia: 12, ano: 2004); 
            //o bom de usar os parametros nomeados é pq deixa o código mais entendível 
        }
    }
}
