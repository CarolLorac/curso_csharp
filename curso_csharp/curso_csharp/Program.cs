using curso_csharp.Api;
using curso_csharp.ClassesEMetodos;
using curso_csharp.Colecoes;
using curso_csharp.Excecoes;
using curso_csharp.MetodosEFuncoes;
using curso_csharp.OrientacaoObjetos;

namespace curso_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>(){

                //Classes e Métodos
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Atributos estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Parametros variáveis (params) - Classes e Métodos", Params.Executar},
                {"Parametros nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters e setters - Classes e Métodos", GetSet.Executar},
                {"Propriedade - Classes e Métodos", Propriedade.Executar},
                {"Atributo readonly - Classes e Métodos", Readonly.Executar},
                {"Enumerador (enum) - Classes e Métodos", Enumerador.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Struct vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Parâmetro com valor padrão - Classes e Métodos", ParametroPadrao.Executar},
                {"Parâmetros por referência - Classes e Métodos", ParametrosPorReferencia.Executar},

                //Coleções
                {"Array - Coleções", UsandoArray.Executar},
                {"List - Coleções", UsandoList.Executar},
                {"Array List - Coleções", UsandoArrayList.Executar},
                {"Set - Coleções", UsandoSet.Executar},
                {"Queue - Coleções", UsandoQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", UsandoStack.Executar},
                {"Dictionary - Coleções", UsandoDictionary.Executar},

                //Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Classe Abstrata - Orientação a Objetos", ClasseAbstrata.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed - Orientação a Objetos", Sealed.Executar},

                //Métodos e Funções
                {"Lambda - Métodos e Funções", Lambda.Executar},
                {"Lambdas como Delegate - Métodos e Funções", LambdaDelegate.Executar},
                {"Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegate com Função Anônima- Métodos e Funções", DelegateComFuncaoAnonima.Executar},
                {"Delegate como Parâmetro- Métodos e Funções", DelegateComoParametro.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},

                //Exceções (erros)
                {"Tratamento de Erro - Exceções", TratamentoErro.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                //Api
                {"Primeiro Arquivo - Api", PrimeiroArquivo.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}