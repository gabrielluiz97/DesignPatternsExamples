using DesignPatterns._02_Structural._2._2_Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._2_Strategy
{
    public class PedidoService 
    {
        private readonly IPagamento _pagamento;

        public PedidoService(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public Pagamento RealizarPagamento(Pedido perdido, Pagamento pagamento)
        {
            return _pagamento.RealizarPagamento(perdido, pagamento);
        }
    }
}
