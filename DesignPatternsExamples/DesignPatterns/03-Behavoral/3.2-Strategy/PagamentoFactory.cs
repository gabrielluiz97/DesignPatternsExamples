using DesignPatterns._02_Structural._2._2_Facade;
using DesignPatterns._02_Structural._2._2_Facade.CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._2_Strategy
{
    public class PagamentoFactory
    {
        public static IPagamento CreatePagamento(MeioDePagamento meioPagamento)
        {
            switch (meioPagamento)
            {
                case MeioDePagamento.CartaoCredito:    
                    return new PagamentoCartaoCreditoServico(
                                new PagamentoCartaoCreditoFacade(
                                    new PayPalGateway(),
                                    new ConfigurationManager()));
                        
                case MeioDePagamento.Boleto:
                    return new PagamentoBoletoServico(new PagamentoBoletoFacade());

                case MeioDePagamento.Transferencia:
                    return new PagamentoTransferenciaServico(new PagamentoTransferenciaFacade());

                default:
                    throw new ApplicationException("Meio de pagamento não conhecido");
            }
        }
    }
}
