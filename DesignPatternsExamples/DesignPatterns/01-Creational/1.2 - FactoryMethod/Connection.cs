using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Creational._1._2___FactoryMethod
{
    public class Connection
    {
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
        public bool Oppened { get; set; }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine($"Executando comando: {command}");
        }

        public void Oppen()
        {
            Oppened = true;

            Console.WriteLine($"Conexão aberta.");
        }       
        
        public void Close()
        {
            Oppened = false;

            Console.WriteLine($"Conexão fechada.");
        }
    }
}
