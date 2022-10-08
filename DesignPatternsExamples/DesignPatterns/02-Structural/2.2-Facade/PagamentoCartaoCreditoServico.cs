using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._2_Facade
{
    public class PagamentoCartaoCreditoServico : IPagamento
    {
        private readonly IPagamentoCartaoCreditoFacade _pagamentoCartaoCreditoFacade;

        public PagamentoCartaoCreditoServico(IPagamentoCartaoCreditoFacade pagamentoCartaoCreditoFacade)
        {
            _pagamentoCartaoCreditoFacade = pagamentoCartaoCreditoFacade;
        }

        public Pagamento RealizarPagamento(Pedido perdido, Pagamento pagamento)
        {
            pagamento.Valor = perdido.Produtos.Sum(p => p.Valor);

            Console.WriteLine($"Iniciando Pagamento via Cartão de crédito - Valor R$ {pagamento.Valor}");

            if(_pagamentoCartaoCreditoFacade.RealizarPagamento(perdido, pagamento))
            {
                pagamento.Status = "Pago via Cartão de Crédito";

                return pagamento;   
            }

            pagamento.Status = "Cartão de crédito Recusado!";
            return pagamento;
        }
    }
}
