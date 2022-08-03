using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.OrientacaoObjetos
{
    class Animal
    {
        public string Nome{ get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)  
        {
            Console.WriteLine($"Cachorro {Nome} inicializado!!");
        }

        public Cachorro(string nome, double altura) : this(nome) //this - "herda" um construtor da própria classe - se tivesse +1 construtor, o programa iria identificar qual você está usando através da quantidade e tipo de parametros passados
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura";
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            Animal loirao = new Cachorro("Loirão");
            Animal pucca = new Cachorro("Pucca", 50);
            Animal lana = new Cachorro("Lana", 70);

            Console.WriteLine(loirao);  //o ToString() é setado automaticamente e tem um override na classe Cachorro, por isso é exibido a frase 
            Console.WriteLine(pucca);
            Console.WriteLine(lana.Nome);
        }
    }
}
