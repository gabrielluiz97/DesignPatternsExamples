using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns._03_Behavoral._3._1_Command.Calculadora;

namespace DesignPatterns._03_Behavoral._3._1_Command
{
    public class ExecucaoCommand
    {
        public static void Executar()
        {
            var usuario = new Usuario();

            usuario.Adicionar(Operacao.Soma, 100);
            Console.ReadKey();
            usuario.Adicionar(Operacao.Subtracao, 50);
            Console.ReadKey();
            usuario.Adicionar(Operacao.Multiplicacao, 10);
            Console.ReadKey();
            usuario.Adicionar(Operacao.Divisao, 2);
            Console.ReadKey();

            usuario.Desfazer(4);
            Console.ReadKey();

            usuario.Retornar(3);
        }
    }
}
