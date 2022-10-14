using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._2_Strategy
{
    public class PagamentoBoletoFacade : IPagamentoBoletoFacade
    {
        public string GerarBoleto()
        {
            return Guid.NewGuid().ToString().ToUpper();   
        }
    }
}
