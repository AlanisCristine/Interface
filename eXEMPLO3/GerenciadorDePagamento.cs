using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    public class GerenciadorDePagamento
    {
        public void ProcessarPagamento(IFormaPagamento formaPagamento, double valorTotal)
        {
            formaPagamento.CalculaValorPagamento(200.0);
        }
    }
}
