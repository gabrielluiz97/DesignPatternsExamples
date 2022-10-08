using DesignPatterns._01_Creational._1._2___FactoryMethod.Factories;

namespace DesignPatterns._01_Creational._1._2___FactoryMethod
{
    public static class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlConnection = DbFactory.Database(DataBase.SqlServer)
                                     .CreateConnector("minhaCS")
                                     .Connect();

            sqlConnection.ExecuteCommand("select * from tabelasql");
            sqlConnection.Close();

            Console.WriteLine($"");
            Console.WriteLine($"-------------------------------------------");
            Console.WriteLine($"");

            var oracleConnection = DbFactory.Database(DataBase.Oracle)
                         .CreateConnector("minhaCS")
                         .Connect();

            oracleConnection.ExecuteCommand("select * from tabelaOracle");
            oracleConnection.Close();
        }
    }
}
