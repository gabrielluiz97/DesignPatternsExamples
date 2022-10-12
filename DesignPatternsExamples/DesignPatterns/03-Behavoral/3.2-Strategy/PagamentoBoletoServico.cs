using DesignPatterns._02_Structural._2._2_Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._2_Strategy
{
    public class PagamentoBoletoServico : IPagamento
    {
        private readonly IPagamentoBoletoFacade _pagamentoBoletoFacade;

        public PagamentoBoletoServico(IPagamentoBoletoFacade pagamentoBoletoFacade)
        {
            _pagamentoBoletoFacade = pagamentoBoletoFacade;
        }

        public Pagamento RealizarPagamento(Pedido perdido, Pagamento pagamento)
        {
            pagamento.Valor = perdido.Produtos.Sum(p => p.Valor);

            Console.WriteLine($"Iniciando Pagamento via Boleto - Valor R$ {pagamento.Valor}");

            pagamento.LinhaDigitavelBoleto = _pagamentoBoletoFacade.GerarBoleto();
            pagamento.Status = "Aguardando Pagamento";
            return pagamento;
        }
    }
}
