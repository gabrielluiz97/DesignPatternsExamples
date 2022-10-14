using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns._03_Behavoral._3._1_Command.Calculadora;

namespace DesignPatterns._03_Behavoral._3._1_Command
{
    internal class CalculadoraCommand : Commander
    {
        private Operacao _operacao;
        private decimal _valor;
        private readonly Calculadora _calculadora;

        public CalculadoraCommand(Operacao operacao, decimal valor, Calculadora calculadora)
        {
            _operacao = operacao;
            _valor = valor;
            _calculadora = calculadora;
        }

        public Operacao Operador
        {
            set => _operacao = value;
        }
              
        
        public decimal operando
        {
            set => _valor = value;
        }

        public override void Desfazer()
        {
            _calculadora.Calcular(Desfazer(_operacao), _valor);
        }

        public override void Executar()
        {
            _calculadora.Calcular(_operacao, _valor);
        }

        public static Operacao Desfazer(Operacao operacao)
        {
            switch (operacao)
            {
                case Operacao.Soma: return Operacao.Subtracao;
                case Operacao.Subtracao: return Operacao.Soma;
                case Operacao.Multiplicacao: return Operacao.Divisao;
                case Operacao.Divisao: return Operacao.Multiplicacao;
                default: throw new ArgumentException("Operador desconhecido");
            }
        }
    }
}
