using curso_csharp.ClassesEMetodos;

namespace curso_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testeee");
            var central = new CentralDeExercicios(new Dictionary<string, Action>(){
                //Classes e métodos
                {"Membros - classes e métodos", Membros.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}