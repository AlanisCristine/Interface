using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    public class Cheque : IFormaPagamento
    {
        public void CalculaValorPagamento(double valorTotal)
        {
            Console.WriteLine($"Como pagamento será realizado através de Cheque, vamos oferecer 15% de desconto, Valor Final será: {valorTotal - (valorTotal * 0.15)}");
        }
    }
}
