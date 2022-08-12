using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/source/repos/curso_csharp/curso_csharp/curso_csharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if(!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("PASTAS ===========");
            var pastas = dirInfo.GetDirectories();
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\nARQUIVOS ========");
            var arquivos = dirInfo.GetFiles();
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo.Name);
            }

            Console.WriteLine("\n\nINFOS GERAIS ========");
            Console.WriteLine(dirInfo.Name); //exibe o nome da pasta
            Console.WriteLine(dirInfo.Root); //exibe a raiz da pasta
            Console.WriteLine(dirInfo.Parent); //exibe a pasta pai
        }
    }
}
