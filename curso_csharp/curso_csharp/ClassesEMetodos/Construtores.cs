using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
    class Carro
    {
        public string? Fabricante;
        public string? Modelo;
        public int Ano;

        //Construtor com parâmetros
        public Carro(string fabricante, string modelo, int ano )
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;
        }

        //Construtor padrão 
        public Carro() {}
    }

    public class Construtores
    {
        public static void Executar()
        {
            Carro carro1 = new Carro();
            carro1.Fabricante = "Toyota";
            carro1.Modelo = "Corola";
            carro1.Ano = 2020;

            Console.WriteLine("{0} {1} {2}", carro1.Fabricante, carro1.Modelo, carro1.Ano);

            Carro carro2 = new Carro("Fiat", "Uno", 2010);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Ka",
                Modelo = "Ford",
                Ano = 2022
            };
            Console.WriteLine(carro3.Fabricante + " " + carro3.Modelo + " " + carro3.Ano);

            //cada carro possui uma forma diferente de usar o construtor e de exibir as informações no console
        }
    }
}
