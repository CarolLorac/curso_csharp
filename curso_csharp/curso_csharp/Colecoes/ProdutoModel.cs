using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Colecoes
{
    public class ProdutoModel
    {
        public string Nome;
        public double Valor;

        public ProdutoModel(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        // selecionar nome da classe > ctrl + ponto > generate Equals e GetHashCode > cria automaticamente os dois métodos
        // esses métodos servem para garatir se que a comparação da igualdade dos valores vai ser correta, ou seja, vai comparar o valor dos atributos e não o endereço de memória
        public override bool Equals(object? obj) //usado na classe Igualdade
        {
            return obj is ProdutoModel model &&
                   Nome == model.Nome &&
                   Valor == model.Valor;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Valor);
        }

        // é essencial usar o equals e o hashCode juntos para ter certeza que vai funcionar certo
    }
}