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
                {"Métodos com retorno - classes e métodos", MetodosComRetorno.Executar},
                {"Atributos estáticos - classes e métodos", AtributosEstaticos.Executar},
                {"Desafio atributo - classes e métodos", DesafioAtributo.Executar},
                {"Parametros variáveis (params) - classes e métodos", Params.Executar},
                {"Parametros nomeados - classes e métodos", ParametrosNomeados.Executar},
                {"Getters e setters - classes e métodos", GetSet.Executar},
                {"Propriedade - classes e métodos", Propriedade.Executar},
                {"Atributo readonly - classes e métodos", Readonly.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}