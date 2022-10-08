using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._1_Adapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            var pagamentoLogPadrao = new TransacaoServico(new Logger());
            pagamentoLogPadrao.RealizarTransacao();

            var pagamentoLogCustom = new TransacaoServico(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustom.RealizarTransacao();
        }
    }
}
