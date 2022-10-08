 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns._03_Behavoral._3._1_Command.Calculadora;

namespace DesignPatterns._03_Behavoral._3._1_Command
{
    public class Usuario
    {
        private readonly Calculadora _calculadora = new Calculadora();
        private readonly List<Commander> _commands = new List<Commander>();
        private int _total;

        public void Adicionar(Operacao operacao, decimal valor)
        {
            Commander commander = new CalculadoraCommand(operacao, valor, _calculadora);
            commander.Executar();

            _commands.Add(commander);

            _total++;
        }

        public void Retornar(int niveis)
        {
            Console.WriteLine($"\n ---- Retornando {niveis} níveis");

            for(var i = 0; i < niveis; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                var command = _commands[_total++];
                command.Executar();
            }
        }

        public void Desfazer(int niveis)
        {
            Console.WriteLine($"\n ---- Desfazendo {niveis} níveis");

            for (var i = 0; i < niveis; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                var command = _commands[--_total];
                command.Desfazer();
            }
        }
    }
}
