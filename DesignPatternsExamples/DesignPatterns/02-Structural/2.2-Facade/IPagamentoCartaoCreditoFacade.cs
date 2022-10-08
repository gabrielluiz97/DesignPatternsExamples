using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._2_Facade
{
    public interface IPagamentoCartaoCreditoFacade
    {
        bool RealizarPagamento(Pedido perdido, Pagamento pagamento);
    }
}
