using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._3_Observable
{
    public class Observador : IObservador
    {
        public Observador(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public void Notificar(Investimento investimento)
        {
            Console.WriteLine($"Notificando {Nome} que {investimento.Simbolo} teve preço alterado para {investimento.Valor} ");
        }
    }
}
