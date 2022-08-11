using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Api
{
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach(var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if(File.Exists(caminho))
                {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar()
        {
            var caminhoOriginal = @"~/caminho_original.txt".ParseHome();
            var caminhoDestino = @"~/caminho_destino.txt".ParseHome();
            var caminhoCopia = @"~/caminho_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOriginal, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOriginal))
            {
                sw.WriteLine("Arquivo original!!");
            }

            FileInfo origem = new FileInfo(caminhoOriginal);

            Console.WriteLine("Informações arquivo: ");
            Console.WriteLine($"Nome - {origem.Name}");
            Console.WriteLine($"Nome completo - {origem.FullName}");
            Console.WriteLine($"Nome diretório - {origem.DirectoryName}");
            Console.WriteLine($"Extensão - {origem.Extension}");
            Console.WriteLine($"Tamanho (em bytes) - {origem.Length}");
            Console.WriteLine($"É somente leitura? {origem.IsReadOnly}");

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
