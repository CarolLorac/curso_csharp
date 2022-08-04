# PROPRIEDADES CSHARP
  **override** - sobrescreve um método que foi definido na classe pai (superclasse)
  para o override funcionar, tem que adicionar virtual no método da classe pai
  ex super classe:
  public virtual int Somar() {} 
  
  classe subclasse:
  public override int Somar() {} 

  **sealed** - proibe qualquer classe ser herdada e qualquer método ser sobrescrito
 
# CLASSES E MÉTODOS

## Construtores
	O nome do construtor é sempre igual ao da classe
	Por padrão, se a classe nao definir um construtor, é dado um construtor padrão, ou seja, sem parâmetros

## Privacidade
	Quando um atributo/método não tem nada escrito indiciando se private ou public, será sempre private

## Diferença entre readonly e const
	readonly - constante de tempo de execução - se o valor da constante poderá por qualquer motivo ser alterado no futuro, então 
	use readonly - é mais flexivel, pode ser usado em qualquer tipo de dados
	const - constante de tempo de compilação - se o valor da constante NUNCA for alterado, então use const - é mais limitada, 
	só pode ser usada em numeros, strings e nulosgit
	https://www.macoratti.net/17/10/c_const1.htm#:~:text=Se%20o%20valor%20da%20constante,for%20alterada%20ent%C3%A3o%20use%20const

## Diferença entre array e list
	A principal diferença entre essas duas coleções é que o array possui um tamanho fixo e a list é dinâmica (cresce de acordo 
	com a quantidade de itens que são adicionados)

## Diferença de queue (fila) e stack (pilha)
   Queue - o primeiro a entrar é o primeiro a sair
   Stack - o primeiro a entrar é o último a sair 

## Manipulação de dados
	item.GetType() - pega o tipo de dado do item (ex: int, double, etc)

## Manipulação de listas
	lista.Add() - adiciona um elemento na lista
	lista.AddRange() - adiciona os elementos de uma lista dentro da lista
	lista.RemoveAt(index) - remove o elemento que está no indice especificado
	lista.IndexOf(item) - verifica o indice do item/elemento especificado

## Manipulação de filas
	fila.Enqueue() - adiciona um item na fila
	fila.Peek() - exibe o primeiro elemento da fila
	fila.Count - exibe a quantidade de elementos na lista
	fila.Dequeue() - remove o primeiro elemento da fila

## Manipulação de pilhas
    pilha.Push() - adiciona um item na pilha
	pilha.Pop() - remove elemento do topo da pilha (último a ser adicionado)
	pilha.Peek() - exibe o elemento do topo da pilha

## Formas de navegar em Dictionary
	foreach (var ano in filmes.Keys) - navega somente nas Keys
    {
        Console.WriteLine(ano.ToString());
    }    

	foreach (var filme in filmes.Values) - navega somente nos Values
    {
        Console.WriteLine(filme);
    }

    foreach (var filme in filmes) - navega no dictionary inteiro
    { 
        Console.WriteLine($"O filme {filme.Value} foi lançado em {filme.Key}"); 
    }	

## Classes abstratas vs Classes concretas vs Interface
	**Classe abstrata** - é uma classe que serve de modelo para as outras classes (se comporta como uma superclasse). 
	Ela não pode ser instânciada e pode possuir métodos concretos e/ou abstratos - métodos abstratos são métodos que não possuem implementação (corpo).
	Obs: Métodos só podem ser abstrados em classes abstratas e sempre devem ser implementados quando a classe for herdada
	**Classe concreta** - é uma classe que possui todos os métodos implementados
	**Interface** - define a estrutura padrão que uma classe deve implementar. TODOS os métodos definidos na interface devem ser implementados.

# PILARES DA ORIENTAÇÃO A OBJETOS (OO)
	A orientação a objetos é o principal paradigma - forma de organizar as ideias para modelar o mundo real dentro de um sistema - do c#

## Abstração 
	É entender o contexto do seu projeto/problema e criar classes somente com atributos e métodos relevantes, por exemplo, 
	a classe cliente terá atributos diferentes para um hospital e uma padaria, já que ela está em contextos diferentes e 
	possui necessidades diferentes
	http://contembits.com.br/minicursos/poo/Abstracao.aspx

## Herança 
	Consiste em reutilizar código. Muitas vezes a mesma funcionalidade é repetida diversas vezes no código, usar a herança
	permite agilizar o desenvolvimento, facilitar manutenção, deixar o projeto mais limpo e evitar reescrever o código.
	
	herança ("É UM(A)"):					composição ("TEM UM(A)"):

	class Animal {}							class Pneu {}
	class Cachorro : Animal {}			    class Carro 
											{
	ex: O cachorro é um animal					public Pneu pneu;
											}
											
											ex: O carro tem um pneu
	http://contembits.com.br/minicursos/poo/Heranca.aspx

## Encapsulamento 
	É quando você esconde parte do código (deixando private), com o objetivo de diminuir a dependencia entre as classes. 
	Só deixa visível e acessável (public) o que realmente for necessário.

### Manipuladores de privacidade:
	* public - qualquer projeto pode acessar 
	* internal - só pode ser acessado dentro do projeto
	* protected - só é acessado dentro da classe e por instâncias (herança) 
	* private - acessado somente dentro da classe 
	http://contembits.com.br/minicursos/poo/Encapsulamento-e-Modificadores-de-Acesso.aspx

## Polimorfismo 
	Consiste em tratar objetos de uma subclasse de forma genérica, como se fossem um objeto da superclasse. 
	Assim, os objetos serão tratados de maneira semelhante e terão resultados/retornos específicos (de acordo com a subclasse)
	Ex: Método para venda de carro
	
		class Carro {}
		class Civic : Carro {}
		class Celta : Carro {}
		class Ferrari : Carro {}

	Correto:
		 void VenderCarro (Carro carro) {}
	
	Errado:
		void VenderCivic (Civic civic) {}
		void VenderCelta (Celta celta) {}
		void VenderFerrari (Ferrari ferrari) {}
	http://contembits.com.br/minicursos/poo/Polimorfismo.aspx 


# CONFIGURAÇÕES

## Como adicionar um novo projeto Class Library (projeto tratado como uma biblioteca):
	1. Clicar com o botão direito no Solution
	2. Add > New Project
	3. Selecionar Class Library > Next
	4. Solution Explorer > Projeto Principal > Dependencies > Clicar com o botão direito
	5. Add Project Reference > Selecionar o projeto que você acabou de criar > ok
	6. Adicionar using na classe que for usar o projeto
