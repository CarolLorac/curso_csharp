using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Colecoes
{
    class UsandoArray
    {
        //Principais carcteristicas do array:
        //1. É homogêneo - só pode ter o mesmo tipo de dado
        //2. Tem tamanho fixo
        //3. Estrutura indexada - acessa os itens através do indice (ex: array[0])

        public static void Executar()
        {
            //array funcionários
            string[] funcionarios = new string[4];

            funcionarios[0] = "Carol";
            funcionarios[1] = "Camila";
            funcionarios[2] = "Leo";
            funcionarios[3] = "Décio";

            Console.WriteLine("Funcionários: ");
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }

            //array notas
            double[] notas = { 10, 9, 7.5, 4.5, 9 };
            double acumNota = 0;
            double media;

            foreach(var nota in notas)
            {
                acumNota += nota;
            }

            media = acumNota / notas.Length;
            Console.WriteLine($"\nMédia: {media}");

            //array letras
            char[] letras = { 'a', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine($"\nPalavra: {palavra}");
        }
    }
}
