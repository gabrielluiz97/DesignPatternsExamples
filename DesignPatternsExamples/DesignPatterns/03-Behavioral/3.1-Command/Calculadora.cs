using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._1_Command
{
    public class Calculadora
    {
        private decimal _valorAtual;

        public void Calcular(Operacao operacao, decimal valor)
        {
            switch (operacao)
            {
                case Operacao.Soma: _valorAtual += valor; break;
                case Operacao.Subtracao: _valorAtual -= valor; break;
                case Operacao.Multiplicacao: _valorAtual *= valor; break;
                case Operacao.Divisao: _valorAtual /= valor; break;
            }

            Console.WriteLine($"(Dado {operacao} {valor}) - Valor atual {_valorAtual}");
        }

        public enum Operacao
        {
            Soma = 0,
            Subtracao = 1,
            Multiplicacao = 2,
            Divisao = 3
        }
    }
}
