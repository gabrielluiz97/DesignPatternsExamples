using DesignPatterns._02_Structural._2._2_Facade.CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._2_Facade
{
    public class ExecucaoFacade
    {
        public static void Executar()
        {
            var produtos = new List<Produto>
            {
                new Produto{Nome = "Tênis Adidas", Valor = new Random().Next(500)},
                new Produto{Nome = "Camisa Boliche", Valor = new Random().Next(500)},
                new Produto{Nome = "Raquete Tênis", Valor = new Random().Next(500)},
            };

            var pedido = new Pedido
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var pagamento = new Pagamento
            {
                CartaoCredito = "5555 2222 5555 9999"
            };

            var pagamentoService = new PagamentoCartaoCreditoServico(new PagamentoCartaoCreditoFacade(new PayPalGateway(), new ConfigurationManager()));

            pagamentoService.RealizarPagamento(pedido, pagamento);
        }
    }
}
