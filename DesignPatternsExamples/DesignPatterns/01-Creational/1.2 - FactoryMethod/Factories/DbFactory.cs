using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Creational._1._2___FactoryMethod.Factories
{
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase dataBase)
        {
            switch (dataBase)
            {
                case DataBase.SqlServer:
                    return new SqlFactory();               
                case DataBase.Oracle:
                    return new OracleFactory();
                default:
                    throw new ApplicationException("Tipo de base de dados deconhecido.");
            }
        }
    }

}
