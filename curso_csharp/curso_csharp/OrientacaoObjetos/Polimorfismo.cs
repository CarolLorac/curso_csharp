using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.OrientacaoObjetos
{
    class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }
    }

    class Arroz : Comida 
    {
        public Arroz(double peso) : base(peso) 
        { 
        }
    }

    class Feijao : Comida
    {
        public Feijao(double peso) : base(peso)
        {
        }
    }

    class Pessoa
    {
        public double Peso;

        public Pessoa(double peso)
        {
            Peso = peso;
        }

        public double Comer(double peso)
        {
            return Peso += peso;
        }
    }

    class Polimorfismo
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa(61);
            Comida arroz = new Arroz(0.1);
            Comida feijao = new Feijao(0.3);

            pessoa.Comer(arroz.Peso);
            pessoa.Comer(feijao.Peso);

            Console.WriteLine($"O peso da pessoa após comer é {pessoa.Peso}kg");


            //Pessoa pessoa = new Pessoa(61);
            //Comida comida = new Arroz(0.1);
            //pessoa.Comer(comida.Peso);

            //comida = new Feijao(); -perguntar qual tipo de contrutor ele acha melhor tbm
            //comida.Peso = 0.3;
            //Console.WriteLine(pessoa.Comer(comida.Peso));
        }
    }
}
