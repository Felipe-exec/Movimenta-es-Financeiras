using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimentacoesFinanceiras.Logic
{
    internal interface Cliente
    {
        void Saque(double dinheiro);
        void Deposito(double dinheiro);
    }
}
