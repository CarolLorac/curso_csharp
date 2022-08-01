# CLASSES E M�TODOS

## Construtores
	O nome do construtor � sempre igual ao da classe
	Por padr�o, se a classe nao definir um construtor, � dado um construtor padr�o, ou seja, sem par�metros

## Privacidade
	Quando um atributo/m�todo n�o tem nada escrito indiciando se private ou public, ser� sempre private

## Diferen�a entre readonly e const
	readonly - constante de tempo de execu��o - se o valor da constante poder� por qualquer motivo ser alterado no futuro, ent�o use readonly - � mais flexivel, pode ser usado em qualquer tipo de dados
	const - constante de tempo de compila��o - se o valor da constante NUNCA for alterado, ent�o use const - � mais limitada, s� pode ser usada em numeros, strings e nulosgit
	https://www.macoratti.net/17/10/c_const1.htm#:~:text=Se%20o%20valor%20da%20constante,for%20alterada%20ent%C3%A3o%20use%20const

## Diferen�a entre array e list
	A principal diferen�a entre essas duas cole��es � que o array possui um tamanho fixo e a list � din�mica (cresce de acordo com a quantidade de itens que s�o adicionados)

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