using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;

        public Agencia agencia;

        //Slide 30 - Criar objetos apenas com saldo acima de 10
        public Conta(long numero, decimal saldo) 
        {
            _numero = numero;
            if (saldo >= 11)
            {
                _saldo = saldo;
            }
            else
            {
                Console.WriteLine("O saldo deve ser superior a R$10 para criar uma conta.");
                throw new ArgumentException("O saldo deve ser superior a R$10 para criar uma conta.");
            }
        }

        public long Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public decimal Saldo 
        { get => _saldo; }


        public void Deposito(decimal valor)
        {
            _saldo += valor;
        }

        public decimal Saque(decimal valor)
        {
            if(_saldo - valor >= 0)
            {
                _saldo -= valor;
                return _saldo;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }
            
        }

    }
}
