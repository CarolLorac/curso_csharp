using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.ClassesEMetodos
{
	public enum GeneroEnum
	{
        [Description("Comédia")]
		Comedia = 0,

        [Description("Ação")]
		Acao = 1,

        [Description("Romance")]
		Romance = 2,

        [Description("Aventura")]
		Aventura = 3,

        [Description("Suspense")]
		Suspense = 4,

        [Description("Terror")]
		Terror = 5
	}

	public class Filme
	{
		public string Nome { get; set; }
		public GeneroEnum Genero { get; set; }

		public Filme(string nome, GeneroEnum genero)
		{
			Nome = nome;
			Genero = genero;
		}
	}

	class Enumerador
    {
		public static void Executar()
		{
			Filme filme = new Filme("Barbie e as princesas", GeneroEnum.Aventura);

			Console.WriteLine($"O filme {filme.Nome} é de {filme.Genero}");
		}
	}
}
