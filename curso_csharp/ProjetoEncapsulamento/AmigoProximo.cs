using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEncapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("\nAMIGO PRÓXIMO");

            Console.WriteLine(amigo.InfoPublica);
            Console.WriteLine(amigo.Telefone);
            Console.WriteLine(amigo.JeitoFalar);
            //Console.WriteLine(amigo.CorOlho);
            //Console.WriteLine(amigo.SegredoFamilia);
            //Console.WriteLine(amigo.UsaPhotoshop);
        }
    }
}
