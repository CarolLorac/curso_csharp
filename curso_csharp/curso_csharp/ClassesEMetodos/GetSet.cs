using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    class Moto
    {
        private string Marca;
        private uint Cilindrada; //OP3

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            Cilindrada = cilindrada;

            //if(cilindrada > 0)   OP1
            //{
            //    Cilindrada = cilindrada;
            //}

            //Cilindrada = Math.Abs(cilindrada);    OP2
        }

    }

    class GetSet
    {
        //get > lê atributo
        //set > altera atributo

        public static void Executar()
        {
            Moto moto = new Moto();

            moto.SetMarca("CBR1000");
            moto.SetCilindrada(800); //se colocar n° neg vai dar erro por causa do uint

            Console.WriteLine("Marca: " + moto.GetMarca());
            Console.WriteLine("Cilindrada: " + moto.GetCilindrada());

            //Formas de garantir que a cilindrada não será nula:
            //OP1 - fazer if de verificação
            //OP2 - utilizar a função Math.Abs que transforma o numero negativo em seu equivalente positivo (-10 > +10)
            //OP3 - utilizar uint ao invés de int - o uint não aceita sinal
        }
    }
}
