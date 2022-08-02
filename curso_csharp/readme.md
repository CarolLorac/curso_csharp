# CLASSES E MÉTODOS

## Construtores
	O nome do construtor é sempre igual ao da classe
	Por padrão, se a classe nao definir um construtor, é dado um construtor padrão, ou seja, sem parâmetros

## Privacidade
	Quando um atributo/método não tem nada escrito indiciando se private ou public, será sempre private

## Diferença entre readonly e const
	readonly - constante de tempo de execução - se o valor da constante poderá por qualquer motivo ser alterado no futuro, então use readonly - é mais flexivel, pode ser usado em qualquer tipo de dados
	const - constante de tempo de compilação - se o valor da constante NUNCA for alterado, então use const - é mais limitada, só pode ser usada em numeros, strings e nulosgit
	https://www.macoratti.net/17/10/c_const1.htm#:~:text=Se%20o%20valor%20da%20constante,for%20alterada%20ent%C3%A3o%20use%20const

## Diferença entre array e list
	A principal diferença entre essas duas coleções é que o array possui um tamanho fixo e a list é dinâmica (cresce de acordo com a quantidade de itens que são adicionados)

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

# Pilares da Orientação a Objetos (OO)
	A orientação a objetos é o principal paradigma - forma de organizar as ideias para modelar o mundo real dentro de um sistema - do c#

	1. Abstração - é entender o contexto do seu projeto/problema e criar classes somente com atributos e métodos relevantes, por exemplo, a classe cliente terá 
    atributos diferentes para um hospital e uma padaria, já que ela está em contextos diferentes e possui necessidades diferentes
	2. Herança - consiste em reutilizar código. Muitas vezes a mesma funcionalidade é repetida diversas vezes no código, usar a herança permite agilizar o desenvolvimento, facilitar manutenção, deixar o projeto mais limpo e evitar reescrever o código.
	
	herança ("É UM(A)"):					composição ("TEM UM(A)"):

	class Animal {}							class Pneu {}
	class Cachorro : Animal {}			    class Carro 
											{
	ex: O cachorro é um animal					public Pneu pneu;
											}
											
											ex: O carro tem um pneu

	3. Encapsulamento - é quando você esconde parte do código (deixando private), com o objetivo de diminuir a dependencia entre as classes. Só deixa visível e acessável (public) o que realmente for necessário