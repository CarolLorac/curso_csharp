using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.OrientacaoObjetos
{
    internal class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade <= 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(10);
        }

        public int Frear()
        {
            return AlterarVelocidade(-10);
        }
    }

    internal class Uno : Carro
    {
        public Uno() : base(velocidadeMaxima: 130) //base - utilizado quando herda uma classe e o construtor dela tem parâmetros. É pelo base que passa os valores para os parametros da classe Carro 
        {
        }
    }

    internal class Ferrari : Carro
    {
        public Ferrari() : base(250)
        {
        }

        public override int Acelerar()
        {
            return AlterarVelocidade(20);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Ferrari carro1 = new Ferrari(); 
            Console.WriteLine("Acelerando ferrari: ");
            for (int i = 0; i < 10; i ++)
            {
                Console.Write($"{carro1.Acelerar()}...");
            }


            Uno carro2 = new Uno();
            Console.WriteLine($"\n\nVelocidade atual uno: {carro2.Acelerar()}");
            Console.WriteLine($"Frear: {carro2.Frear()}");
            Console.WriteLine($"Frear novamente: {carro2.Frear()}");


            Carro carro3 = new Ferrari(); //Polimorfismo
            Console.WriteLine($"\n\nAcelerando como ferrari: {carro3.Acelerar()}");
            carro3 = new Uno(); //benefício do polimorfismo
            Console.WriteLine($"Acelerando como uno: {carro3.Acelerar()}");
        }
    }
}
