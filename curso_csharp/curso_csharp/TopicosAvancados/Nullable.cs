using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.TopicosAvancados
{
    class ExemploNullable
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if(num1.HasValue)
            {
                Console.WriteLine($"O valor de num1 é {num1}");
            }
            else
            {
                Console.WriteLine("Não possui valor!!");
            }

            int valor = num1 ?? 0; //se a varival for null, vai substituir por 0
            Console.WriteLine(valor);

            try
            {
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y); //vai dar erro pq não da para fazer operação com variaveis nulas
            } 
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
