using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1; //private
        string nome; 

        public string Nome
        {
            get
            {
                return $"Carro: {nome}";
            }
            set
            {
                nome = value; 
            }
        }

        public double Preco { get; set; }

        //somente leitura
        public double PrecoComDesconto
        {
            get => Preco - Preco * desconto;

            //linha acima é a mesma coisa que:
            //get
            //{
            //    return Preco - Preco * desconto;
            //}
        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    class Propriedade 
    {
        public static void Executar()
        {
            CarroOpcional carro = new CarroOpcional("Corola", 70000);

            Console.WriteLine(carro.Nome + " R$" + carro.Preco);
            Console.WriteLine("Valor com desconto: " + carro.PrecoComDesconto);
        }
    }
}
