using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string? home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX) //Environment.OSVersion.Platform - acessa o sistema operacional da sua máquina
                ? Environment.GetEnvironmentVariable("HOME") //variavel de ambiente do unix e do mac
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%"); //variavel de ambient do windows
            return path.Replace("~", home);
        }

    }

    class PrimeiroArquivo
    {
        //usa para obter  apasta home do usuario -> variaveis de ambiente
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)) //cria arquivo
                {
                    sw.WriteLine("Esse é a primeira linha do arquivo");
                    sw.WriteLine("Segunda linha!!");
                }
            }
            using(StreamWriter sw = File.AppendText(path)) //edita arquivo
            {
                sw.WriteLine("\nÚltima linha adicionada!!");
            }
        }
    }
}
