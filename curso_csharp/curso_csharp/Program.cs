using curso_csharp.ClassesEMetodos;
using curso_csharp.Colecoes;

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
                {"Enumerador (enum) - classes e métodos", Enumerador.Executar},
                {"Struct - classes e métodos", Struct.Executar},
                {"Struct vs Classe - classes e métodos", StructVsClasse.Executar},
                {"Parâmetro com valor padrão - classes e métodos", ParametroPadrao.Executar},
                {"Parâmetros por referência - classes e métodos", ParametrosPorReferencia.Executar},

                //Coleções
                {"Array - coleções", UsandoArray.Executar},
                {"List - coleções", UsandoList.Executar},
                {"Array List - coleções", UsandoArrayList.Executar},
                {"Set - coleções", UsandoSet.Executar},
                {"Queue - coleções", UsandoQueue.Executar},
                {"Igualdade - coleções", Igualdade.Executar},
                {"Stack - coleções", UsandoStack.Executar},
                {"Dictionary - coleções", UsandoDictionary.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}