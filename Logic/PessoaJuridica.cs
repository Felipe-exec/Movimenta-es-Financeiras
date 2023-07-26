using System;
using System.Collections.Generic;

namespace MovimentacoesFinanceiras.Logic
{
    internal class PessoaJuridica : Cliente
    {
        public string razaoSocial;
        public int cnpj;
        public double saldo;
        public List<string> extrato = new List<string>();

        public PessoaJuridica(string razaoSocial, int cnpj, double saldoInicial)
        {
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
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
                saldo -= dinheiro;
                extrato.Add("-R$" + dinheiro.ToString());
            }
        }

        public void Deposito(double dinheiro)
        {
            saldo += dinheiro;
            extrato.Add("+R$" + dinheiro.ToString());
        }
    }
}
