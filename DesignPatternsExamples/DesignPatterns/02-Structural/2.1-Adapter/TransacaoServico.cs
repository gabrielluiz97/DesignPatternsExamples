using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._1_Adapter
{
    public class TransacaoServico
    {
        private readonly Ilogger _logger;

        public TransacaoServico(Ilogger logger)
        {
            _logger = logger;
        }

        public void RealizarTransacao()
        {
            _logger.Log("Transação realizada.");
        }
    }
}
