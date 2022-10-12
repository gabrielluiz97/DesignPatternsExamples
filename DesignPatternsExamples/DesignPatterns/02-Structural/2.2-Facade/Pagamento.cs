using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._2_Facade
{
    public class Pagamento
    {
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public MeioDePagamento MeioDePagamento { get; set; }

        //Poderia usar herança
        public string CartaoCredito { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
        public string ConfirmacaoTransferencia { get; set; }
    }

    public enum MeioDePagamento 
    {
        CartaoCredito = 0,
        Boleto = 1,
        Transferencia = 2,
    }
}
