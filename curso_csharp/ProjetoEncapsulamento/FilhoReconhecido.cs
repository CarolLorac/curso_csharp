using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEncapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos() // dessa forma você está sobreescrevendo o método MeusAcessos só nessa classe, não afeta o método da classe pai
        {
            Console.WriteLine("\nFILHO RECONHECIDO");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(Telefone);
            Console.WriteLine(JeitoFalar);
            Console.WriteLine(CorOlho);
            Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaPhotshop);
        }
    }
}
