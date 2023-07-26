using System;

namespace MovimentacoesFinanceiras.View
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var pessoaJuridica = new Logic.PessoaJuridica("Empresa XYZ", 123456789, 1000.00);
            var pessoaFisica = new Logic.PessoaFisica("João Silva", 987654321, 500.00);

            //-------------------------------------
            ExibirInformacoesConta(pessoaJuridica);
            ExibirInformacoesConta(pessoaFisica);
            //-------------------------------------

            // Realizando algumas operações de saque e depósito
            pessoaJuridica.Deposito(500.00);
            pessoaJuridica.Saque(300.00);
            pessoaFisica.Deposito(200.00);
            pessoaFisica.Saque(100.00);

            ExibirExtrato(pessoaJuridica);
            ExibirExtrato(pessoaFisica);

            //-------------------------------------
            ExibirInformacoesConta(pessoaJuridica);
            ExibirInformacoesConta(pessoaFisica);
            //-------------------------------------
        }

        private static void ExibirInformacoesConta(Logic.Cliente cliente)
        {
            if (cliente is Logic.PessoaJuridica pessoaJuridica)
            {
                Console.WriteLine("===== Informações da Pessoa Jurídica =====");
                Console.WriteLine("Razão Social: " + pessoaJuridica.razaoSocial);
                Console.WriteLine("CNPJ: " + pessoaJuridica.cnpj);
                Console.WriteLine("Saldo: R$" + pessoaJuridica.saldo);
            }
            else if (cliente is Logic.PessoaFisica pessoaFisica)
            {
                Console.WriteLine("===== Informações da Pessoa Física =====");
                Console.WriteLine("Nome: " + pessoaFisica.nome);
                Console.WriteLine("CPF: " + pessoaFisica.cpf);
                Console.WriteLine("Saldo: R$" + pessoaFisica.saldo);
            }

            Console.WriteLine("============================");
        }

        private static void ExibirExtrato(Logic.Cliente cliente)
        {
            if (cliente is Logic.PessoaJuridica pessoaJuridica)
            {
                Console.WriteLine("===== Extrato da Pessoa Jurídica =====");
                foreach (var operacao in pessoaJuridica.extrato)
                {
                    Console.WriteLine(operacao);
                }
            }
            else if (cliente is Logic.PessoaFisica pessoaFisica)
            {
                Console.WriteLine("===== Extrato da Pessoa Física =====");
                foreach (var operacao in pessoaFisica.extrato)
                {
                    Console.WriteLine(operacao);
                }
            }

            Console.WriteLine("============================");
        }
    }
}
