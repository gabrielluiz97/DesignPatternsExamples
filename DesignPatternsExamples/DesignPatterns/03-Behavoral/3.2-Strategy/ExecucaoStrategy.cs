using DesignPatterns._02_Structural._2._2_Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._2_Strategy
{
    public static class ExecucaoStrategy
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

            var meioDePagamentoCredito = new Pagamento
            {
                MeioDePagamento = MeioDePagamento.CartaoCredito,
                CartaoCredito = "5555 2222 5555 9999"
            };           
            
            var meioDePagamentoBoleto = new Pagamento
            {
                MeioDePagamento = MeioDePagamento.Boleto,
            };           
            
            var meioDePagamentoTransferencia = new Pagamento
            {
                MeioDePagamento = MeioDePagamento.Transferencia,
            };

            var pedidoCredito = new PedidoService(PagamentoFactory.CreatePagamento(MeioDePagamento.CartaoCredito));
            var pagamentoCredito = pedidoCredito.RealizarPagamento(pedido, meioDePagamentoCredito);
            Console.WriteLine(pagamentoCredito.Status);
            Console.WriteLine("-------------------------------------------------------------------------");          
            
            var pedidoBoleto = new PedidoService(PagamentoFactory.CreatePagamento(MeioDePagamento.Boleto));
            var pagamentoBoleto = pedidoBoleto.RealizarPagamento(pedido, meioDePagamentoBoleto);
            Console.WriteLine(pagamentoBoleto.Status);
            Console.WriteLine("-------------------------------------------------------------------------");          
            
            var pedidoTransferencia = new PedidoService(PagamentoFactory.CreatePagamento(MeioDePagamento.Transferencia));
            var pagamentoTrasferencia = pedidoTransferencia.RealizarPagamento(pedido, meioDePagamentoTransferencia);
            Console.WriteLine(pagamentoTrasferencia.Status);

        }
    }
}
