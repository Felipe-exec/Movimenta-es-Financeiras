using System;
using System.Collections.Generic;

namespace MovimentacoesFinanceiras.Logic
{
    internal class PessoaFisica : Cliente
    {
        public string nome;
        public int cpf;
        public double saldo;
        public List<string> extrato = new List<string>();

        public PessoaFisica(string nome, int cpf, double saldoInicial)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.saldo = saldoInicial;
        }

        public void Saque(double dinheiro)
        {
            if (saldo < dinheiro)
            {
                Console.WriteLine("Impossível sacar. Saldo insuficiente.");
            }
            else
            {
                this.saldo -= dinheiro;
                extrato.Add("-R$" + dinheiro.ToString());
            }
        }

        public void Deposito(double dinheiro)
        {
            this.saldo += dinheiro;
            extrato.Add("+R$" + dinheiro.ToString());
        }
    }
}
