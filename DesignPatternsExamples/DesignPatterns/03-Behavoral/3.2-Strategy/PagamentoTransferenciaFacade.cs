using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._2_Strategy
{
    public class PagamentoTransferenciaFacade : IPagamentoTransferenciaFacade
    {
        public string RealizarTransferencia()
        {
            return $"Pagamento realizado - Código da transfeência: {Guid.NewGuid().ToString().ToUpper()}";
        }
    }
}
