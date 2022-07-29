using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta); //em interface, quando nao tem nada escrito é public
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X = X + delta;
            Y = Y + delta;
        }
    }
     

    class Struct
    {
        public static void Executar()
        {
            //diferente do class, com o struct é possivel inicializar de 2 manieras diferentes:
            //1 - Coordenada coordenadaInicial;
            //2 - var coordenadaFinal = new Coordenada(x: 10, y: 5);

            Coordenada coordenadaInicial;

            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada inicial: ");
            Console.WriteLine($"X: {coordenadaInicial.X}");
            Console.WriteLine($"Y: {coordenadaInicial.Y}");

            var coordenadaFinal = new Coordenada(x: 10, y: 5);
            coordenadaFinal.MoverNaDiagonal(2);

            Console.WriteLine("Coordenada final: ");
            Console.WriteLine($"X: {coordenadaFinal.X}");
            Console.WriteLine($"Y: {coordenadaFinal.Y}");
        }
    }
}
