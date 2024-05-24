using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    // Slide 26 Criação da Classe Cliente
    internal class Cliente
    {
        private string _nome;
        private int _idade;
        private string _cpf;
        private Conta _conta;

        public Cliente(string nome, int idade, string cpf, Conta conta)
        {
            _nome = nome;
            _idade = idade;
            _cpf = cpf;
            _conta = conta;

        }
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public int Idade
        {
            get => _idade;
            set { if (value >= 18)
                {
                    _idade = value;
                }else{
                    Console.WriteLine("Um cliente precisa ter 18 anos ou mais");
                }

            }
        }
        //Slide 26 - Vinculando a Classe Conta a Classe Cliente
        public Conta Conta
        {
            get => _conta;
            set => _conta = value;
        }

        public string Cpf
        {

            get => _cpf;
            set { if (value.Length == 11)
                {
                    _cpf = value;
                }
                else
                {
                    Console.WriteLine("Entre com um cpf valido (Tamanho 11 , Apenas Numeros)");
                }
                    
            }
        }
    }
}
