using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Creational._1._1___AbstractFactory
{
    public abstract class Veiculo
    {
        protected Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; set; }
        public Porte Porte { get; set; }
    }

    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo)
            :base(modelo, Porte.Pequeno)
        {
        }

        public string Modelo { get; set; }
        public Porte Porte { get; set; }
    }    

    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo)
            :base(modelo, Porte.Medio)
        {
        }

        public string Modelo { get; set; }
        public Porte Porte { get; set; }
    }

    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo)
            : base(modelo, Porte.Grande)
        {
        }

        public string Modelo { get; set; }
        public Porte Porte { get; set; }
    }

    public static class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new VeiculoPequeno(modelo);
                case Porte.Medio:
                    return new VeiculoMedio(modelo);
                case Porte.Grande:
                    return new VeiculoGrande(modelo);
                default:
                    throw new NotImplementedException("Porte de veiculo desconhecido.");
            }
        }
    }

    public enum Porte
    {
        Pequeno = 0,
        Medio = 1,
        Grande = 2
    }
}
