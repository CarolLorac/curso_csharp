using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_csharp.Excecoes
{
    class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if(valor > Saldo)
            {
               throw new ArgumentException("O valor deve ser menor que o saldo para realizar o saque!!"); //é obrigatório ter o throw para exibir o erro
            }

            Saldo -= valor;
        }
    }

    class TratamentoErro
    {
        public static void Executar()
        {
            try
            {
                Conta conta = new Conta(saldo: 1990.90);
                conta.Sacar(2000);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally //é sempre executado
            {
                Console.WriteLine("Obrigado!!");
            }
        }
    }
}
