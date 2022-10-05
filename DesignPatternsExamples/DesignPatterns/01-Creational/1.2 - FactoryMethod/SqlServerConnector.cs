using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Creational._1._2___FactoryMethod
{
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString)
            : base(connectionString)
        {

        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco SQL server...");

            var connection = new Connection(ConnectionString);

            connection.Oppen();

            return connection;
        }
    }
}
