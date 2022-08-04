# PROPRIEDADES CSHARP
  **override** - sobrescreve um m�todo que foi definido na classe pai (superclasse)
  para o override funcionar, tem que adicionar virtual no m�todo da classe pai
  ex super classe:
  public virtual int Somar() {} 
  
  classe subclasse:
  public override int Somar() {} 

  **sealed** - proibe qualquer classe ser herdada e qualquer m�todo ser sobrescrito
 
# CLASSES E M�TODOS

## Construtores
	O nome do construtor � sempre igual ao da classe
	Por padr�o, se a classe nao definir um construtor, � dado um construtor padr�o, ou seja, sem par�metros

## Privacidade
	Quando um atributo/m�todo n�o tem nada escrito indiciando se private ou public, ser� sempre private

## Diferen�a entre readonly e const
	readonly - constante de tempo de execu��o - se o valor da constante poder� por qualquer motivo ser alterado no futuro, ent�o 
	use readonly - � mais flexivel, pode ser usado em qualquer tipo de dados
	const - constante de tempo de compila��o - se o valor da constante NUNCA for alterado, ent�o use const - � mais limitada, 
	s� pode ser usada em numeros, strings e nulosgit
	https://www.macoratti.net/17/10/c_const1.htm#:~:text=Se%20o%20valor%20da%20constante,for%20alterada%20ent%C3%A3o%20use%20const

## Diferen�a entre array e list
	A principal diferen�a entre essas duas cole��es � que o array possui um tamanho fixo e a list � din�mica (cresce de acordo 
	com a quantidade de itens que s�o adicionados)

## Diferen�a de queue (fila) e stack (pilha)
   Queue - o primeiro a entrar � o primeiro a sair
   Stack - o primeiro a entrar � o �ltimo a sair 

## Manipula��o de dados
	item.GetType() - pega o tipo de dado do item (ex: int, double, etc)

## Manipula��o de listas
	lista.Add() - adiciona um elemento na lista
	lista.AddRange() - adiciona os elementos de uma lista dentro da lista
	lista.RemoveAt(index) - remove o elemento que est� no indice especificado
	lista.IndexOf(item) - verifica o indice do item/elemento especificado

## Manipula��o de filas
	fila.Enqueue() - adiciona um item na fila
	fila.Peek() - exibe o primeiro elemento da fila
	fila.Count - exibe a quantidade de elementos na lista
	fila.Dequeue() - remove o primeiro elemento da fila

## Manipula��o de pilhas
    pilha.Push() - adiciona um item na pilha
	pilha.Pop() - remove elemento do topo da pilha (�ltimo a ser adicionado)
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
        Console.WriteLine($"O filme {filme.Value} foi lan�ado em {filme.Key}"); 
    }	

## Classes abstratas vs Classes concretas vs Interface
	**Classe abstrata** - � uma classe que serve de modelo para as outras classes (se comporta como uma superclasse). 
	Ela n�o pode ser inst�nciada e pode possuir m�todos concretos e/ou abstratos - m�todos abstratos s�o m�todos que n�o possuem implementa��o (corpo).
	Obs: M�todos s� podem ser abstrados em classes abstratas e sempre devem ser implementados quando a classe for herdada
	**Classe concreta** - � uma classe que possui todos os m�todos implementados
	**Interface** - define a estrutura padr�o que uma classe deve implementar. TODOS os m�todos definidos na interface devem ser implementados.

# PILARES DA ORIENTA��O A OBJETOS (OO)
	A orienta��o a objetos � o principal paradigma - forma de organizar as ideias para modelar o mundo real dentro de um sistema - do c#

## Abstra��o 
	� entender o contexto do seu projeto/problema e criar classes somente com atributos e m�todos relevantes, por exemplo, 
	a classe cliente ter� atributos diferentes para um hospital e uma padaria, j� que ela est� em contextos diferentes e 
	possui necessidades diferentes
	http://contembits.com.br/minicursos/poo/Abstracao.aspx

## Heran�a 
	Consiste em reutilizar c�digo. Muitas vezes a mesma funcionalidade � repetida diversas vezes no c�digo, usar a heran�a
	permite agilizar o desenvolvimento, facilitar manuten��o, deixar o projeto mais limpo e evitar reescrever o c�digo.
	
	heran�a ("� UM(A)"):					composi��o ("TEM UM(A)"):

	class Animal {}							class Pneu {}
	class Cachorro : Animal {}			    class Carro 
											{
	ex: O cachorro � um animal					public Pneu pneu;
											}
											
											ex: O carro tem um pneu
	http://contembits.com.br/minicursos/poo/Heranca.aspx

## Encapsulamento 
	� quando voc� esconde parte do c�digo (deixando private), com o objetivo de diminuir a dependencia entre as classes. 
	S� deixa vis�vel e acess�vel (public) o que realmente for necess�rio.

### Manipuladores de privacidade:
	* public - qualquer projeto pode acessar 
	* internal - s� pode ser acessado dentro do projeto
	* protected - s� � acessado dentro da classe e por inst�ncias (heran�a) 
	* private - acessado somente dentro da classe 
	http://contembits.com.br/minicursos/poo/Encapsulamento-e-Modificadores-de-Acesso.aspx

## Polimorfismo 
	Consiste em tratar objetos de uma subclasse de forma gen�rica, como se fossem um objeto da superclasse. 
	Assim, os objetos ser�o tratados de maneira semelhante e ter�o resultados/retornos espec�ficos (de acordo com a subclasse)
	Ex: M�todo para venda de carro
	
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


# CONFIGURA��ES

## Como adicionar um novo projeto Class Library (projeto tratado como uma biblioteca):
	1. Clicar com o bot�o direito no Solution
	2. Add > New Project
	3. Selecionar Class Library > Next
	4. Solution Explorer > Projeto Principal > Dependencies > Clicar com o bot�o direito
	5. Add Project Reference > Selecionar o projeto que voc� acabou de criar > ok
	6. Adicionar using na classe que for usar o projeto
