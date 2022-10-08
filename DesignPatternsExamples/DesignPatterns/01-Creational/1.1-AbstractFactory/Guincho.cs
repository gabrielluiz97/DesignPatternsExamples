using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Creational._1._1___AbstractFactory
{
    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
        Porte Porte { get; set; }
    }

    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno()
            :base(Porte.Pequeno)
        {

        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo carro {veiculo.Porte} - Modelo: {veiculo.Modelo}");
        }
    }    
    
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio()
            :base(Porte.Medio)
        {

        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo carro {veiculo.Porte} - Modelo: {veiculo.Modelo}");
        }
    }

    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande()
            : base(Porte.Grande)
        {

        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo carro {veiculo.Porte} - Modelo: {veiculo.Modelo}");
        }
    }

    public static class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            switch(porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno();       
                case Porte.Medio:
                    return new GuinchoMedio();               
                case Porte.Grande:
                    return new GuinchoGrande();
                default:
                    throw new NotImplementedException("Porte de guincho não conhecido.");    
            }
        }
    }
}
