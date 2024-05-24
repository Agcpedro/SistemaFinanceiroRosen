using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    internal class Operacao
    {
        public Operacao()
        {
        }

        //Slide 26 - Compara Saldo de 2 contas e retorna o numero da conta com o maior saldo
        public long CamparaMaiorSaldo(Conta conta1, Conta conta2)
        {
            decimal saldo1 = conta1.Saldo;
            decimal saldo2 = conta2.Saldo;

            decimal maiorsaldo = Math.Max(saldo1, saldo2);

            if (maiorsaldo == saldo1)
            {
                return conta1.Numero;
            }
            else
            {
                return conta2.Numero;
            }

        }
    }
}
