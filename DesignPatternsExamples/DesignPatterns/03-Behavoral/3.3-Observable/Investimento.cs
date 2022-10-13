using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._3_Observable
{
    //Subject
    public abstract class Investimento
    {
        private decimal _valor;
        private readonly IList<IObservador> _observadores = new List<IObservador>();    

        protected Investimento(string simbolo, decimal valor)
        {

        }

        public string Simbolo { get; set; }

        public decimal Valor { 
            get=> _valor;
            set { 
                if(_valor == value) return;

                _valor = value;
                Notificar();
            } 
        }

        public void Subscribe(IObservador observador)
        {
            _observadores.Add(observador);
            Console.WriteLine($"Notificando que {observador.Nome} está recebendo atualizações de {Simbolo}");
        }

        public void UnSubscribe(IObservador observador)
        {
            _observadores.Remove(observador);
            Console.WriteLine($"Notificando que {observador.Nome} NÁO está recebendo atualizações de {Simbolo}");
        }

        private void Notificar()
        {
            foreach (var observador in _observadores)
            {
                observador.Notificar(this);
            }

            Console.WriteLine($"");
        }
    }
}
