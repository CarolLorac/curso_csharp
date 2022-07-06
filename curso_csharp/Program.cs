using curso_csharp.ClassesEMetodos;

namespace curso_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>(){
                //Classes e métodos
                {"Construtores - classes e métodos", Construtores.Executar},
                {"Métodos com retorno - classes e métodos", MetodosComRetorno.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}