using DesignPatterns._02_Structural._2._2_Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._2_Strategy
{
    public class PagamentoTransferenciaServico : IPagamento
    {
        private readonly IPagamentoTransferenciaFacade _pagamentoTransferenciaFacade;

        public PagamentoTransferenciaServico(IPagamentoTransferenciaFacade pagamentoTransferenciaFacade)
        {
            _pagamentoTransferenciaFacade = pagamentoTransferenciaFacade;
        }

        public Pagamento RealizarPagamento(Pedido perdido, Pagamento pagamento)
        {
            pagamento.Valor = perdido.Produtos.Sum(p => p.Valor);

            Console.WriteLine($"Iniciando Pagamento via Transferência - Valor R$ {pagamento.Valor}");

            pagamento.ConfirmacaoTransferencia = _pagamentoTransferenciaFacade.RealizarTransferencia();

            pagamento.Status = "Pago via Transferência";
            return pagamento;
        }
    }
}
