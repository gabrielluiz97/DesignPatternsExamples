using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._2_Facade.CrossCutting
{
    public interface IPayPalGateway
    {
        bool CommitTransaction(string cardHashKey, string orderId, decimal ammount);
        string GetCardHashKey(string serviceKey, string cartaoCredito);
        string GetPayPalServiceKey(string apiKey, string encriptionKey);
    }
}
