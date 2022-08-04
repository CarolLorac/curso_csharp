using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.OrientacaoObjetos
{
    sealed class SemFilho
    {
        public void ValorFortuna()
        {
            Console.WriteLine("Fortuna: 1.928.999,00");
        }
    }

    //class Filho : SemFilho
    //{
    //}

    class Avo
    {
        public virtual bool HonrarFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public override sealed bool HonrarFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarFamilia() - não permite sobreescrever por causa do sealed adicionado no método do pai
        //{
        //    return false;
        //}
    }

    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            semFilho.ValorFortuna();

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine($"Filho rebelde deve honrar a família: {filhoRebelde.HonrarFamilia()}");

        }
    }
}
