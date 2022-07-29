using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Colecoes
{
    class UsandoArrayList
    {
        //É uma lista que permite armazenar diversos tipos de dados  diferentes
        public static void Executar()
        {
            var arrayList = new ArrayList
            {
                "Caroline",
                18,
                true
            };

            arrayList.Add(1.61);

            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
}
