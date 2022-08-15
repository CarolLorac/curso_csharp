using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Api
{
    class ExemploTimeSpan //espaço de tempo entre 2 horarios/datas
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 20);
            Console.WriteLine(intervalo); //dias.horas:minutos:segundos

            Console.WriteLine($"Minutos: {intervalo.Minutes}");
            Console.WriteLine($"Intervalo total em minutos: {intervalo.TotalMinutes}");

            var largada = DateTime.Now;
            var chegada = largada.AddHours(3);

            TimeSpan tempo = chegada - largada;
            Console.WriteLine($"Intervalo entre largada e chegada: {tempo}");

        }
    }
}
