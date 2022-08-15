
namespace curso_csharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var datetime = new DateTime(year: 2022, month: 08, day: 17);

            Console.WriteLine(datetime);
            Console.WriteLine(datetime.Year); //ano
            Console.WriteLine(datetime.Month); //mes
            Console.WriteLine(datetime.Day); //dia

            var hoje = DateTime.Today;
            Console.WriteLine($"\nHoje: {hoje}");

            var agora = DateTime.Now; //mostra o dia com a hora junto
            Console.WriteLine($"Agora: {agora}");
            Console.WriteLine($" - horas: {agora.Hour}"); //hora
            Console.WriteLine($" - minutos: {agora.Minute}"); //minuto

            var ontem = hoje.AddDays(-1);
            Console.WriteLine($"Ontem: {ontem.Day}");

            var amanha = hoje.AddDays(1);
            Console.WriteLine($"Amanhã: {amanha.Day}");

            Console.WriteLine("\nHorário com formatações: ");
            Console.WriteLine(agora.ToString("dd")); //somente dia
            Console.WriteLine(agora.ToString("d")); //data com dia, mes e ano
            Console.WriteLine(agora.ToString("D")); //data com dia da semana, dia, mes e ano por escrito
            Console.WriteLine(agora.ToString("g")); //data com horário (hora e minuto)
            Console.WriteLine(agora.ToString("G")); //data com horario (hora, minuto e segundo)
            Console.WriteLine(agora.ToString("dd-MM-yyyy HH:mm")); //formatação completa
        }
    }
}
