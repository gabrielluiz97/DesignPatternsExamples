using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._3_Observable
{
    public interface IObservador
    {
        string Nome { get; set; }
        void Notificar(Investimento investimento);
    }
}
