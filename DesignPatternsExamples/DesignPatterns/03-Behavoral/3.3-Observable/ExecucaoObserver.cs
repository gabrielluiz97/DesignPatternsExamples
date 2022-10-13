using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._3_Observable
{
    public static class ExecucaoObserver
    {
        public static void Executar()
        {
            var joao = new Observador("Joao");
            var eduardo = new Observador("Eduardo");
            var bill = new Observador("Bill");

            var amazon = new PapelIBovespa("Amazon", NextDecimal());
            var microsoft = new PapelIBovespa("Microsoft", NextDecimal());

            amazon.Subscribe(joao);
            amazon.Subscribe(eduardo);

            microsoft.Subscribe(eduardo);
            microsoft.Subscribe(bill);

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");


            for(int i = 0; i < 5; i++)
            {
                amazon.Valor = NextDecimal();
                microsoft.Valor = NextDecimal();

                if (i == 1)
                    amazon.UnSubscribe(eduardo);
            }
        }

        public static decimal NextDecimal()
        {
            var random = new Random();

            var value = random.Next(141421, 314160);

            return value / (decimal) 100000.00;
        }
    }
}
