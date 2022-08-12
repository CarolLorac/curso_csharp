using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Api
{
    class Diretorios //pastas
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/curso_csharp/curso_csharp/curso_csharp".ParseHome();

            if(Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true); 
                //esse true é em reclação ao tipo de Delete, se for recursivo (true) vai apagar TUDO que estiver dentro
            }

            if(Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("PASTAS ====================");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\nARQUIVOS =================");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\nRAIZ =============");
            Console.WriteLine(Directory.GetDirectoryRoot(dirProjeto));
        }
    }
}
