using ProjetoEncapsulamento;
using System;

namespace curso_csharp.OrientacaoObjetos
{
    class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("\nFILHO NÃO RECONHECIDO");

            Console.WriteLine(InfoPublica);
            //Console.WriteLine(Telefone);
            Console.WriteLine(JeitoFalar);
            Console.WriteLine(CorOlho);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaPhotoshop);
        }
    }

    class AmigoDistante
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("\nAMIGO DISTANTE");

            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.Telefone);
            //Console.WriteLine(amigo.JeitoFalar);
            //Console.WriteLine(amigo.CorOlho);
            //Console.WriteLine(amigo.SegredoFamilia);
            //Console.WriteLine(amigo.UsaPhotoshop);
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
             SubCelebridade subCelebridade = new SubCelebridade(); //guarda os dados da instancia dentro de uma variável
             subCelebridade.MeusAcessos();

            new FilhoReconhecido().MeusAcessos(); //instância, mas não armazena os dados
            new AmigoProximo().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
