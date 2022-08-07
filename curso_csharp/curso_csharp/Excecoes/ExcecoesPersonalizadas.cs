using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }

    class ExcecoesPersonalizadas
    {
        public static int GerarNumero()
        {
            Random random = new Random();
            int num = random.Next(-30, 30);

            if(num < 0)
            {
                throw new NegativoException("Número negativo :(");
            }

            if(num % 2 != 0)
            {
                throw new ImparException("Número impar!!");
            }

            return num;
        }

        public static void Executar()
        {
            try
            {
                Console.WriteLine(GerarNumero());
            } 
            catch (ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
