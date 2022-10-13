using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._3_Observable
{
    public class PapelIBovespa : Investimento
    {
        public PapelIBovespa(string simbolo, decimal valor)
            : base(simbolo, valor)
        {
        }
    }
}
