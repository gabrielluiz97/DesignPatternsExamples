using DesignPatterns._02_Structural._2._2_Facade.CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._2_Facade
{
    public class PagamentoCartaoCreditoFacade : IPagamentoCartaoCreditoFacade
    {
        private readonly IPayPalGateway _PaypalGateway;
        private readonly IConfigurationManager _configurationManager;

        public PagamentoCartaoCreditoFacade(IPayPalGateway paypalGateway, IConfigurationManager configurationManager)
        {
            _PaypalGateway = paypalGateway;
            _configurationManager = configurationManager;
        }

        public bool RealizarPagamento(Pedido perdido, Pagamento pagamento)
        {
            var apiKey = _configurationManager.GetValue("apiKey"); 
            var encriptionKey = _configurationManager.GetValue("encriptionKey");

            var serviceKey = _PaypalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
            var cardHashKey = _PaypalGateway.GetCardHashKey(serviceKey, pagamento.CartaoCredito);

            var pagamentoResult = _PaypalGateway.CommitTransaction(cardHashKey, perdido.Id.ToString(), pagamento.Valor);

            return pagamentoResult;
        }
    }
}
