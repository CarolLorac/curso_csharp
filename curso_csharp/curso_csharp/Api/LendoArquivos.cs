using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Api
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("PRODUTO  VALOR");
                    sw.WriteLine("Caneta   2,50");
                    sw.WriteLine("Borracha 5,00");
                }
            }

            Console.WriteLine("Digite algo para ser inserido no arquivo: ");
            var textConsole = Console.ReadLine();

            if(textConsole != "")
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(textConsole);
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var text = sr.ReadToEnd();
                    Console.WriteLine($"Texto arquivo:\n{text}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
