using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._2_Facade.CrossCutting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string key)
        {
            IDictionary<string, string> credential = new Dictionary<string, string>();

            credential.Add("apiKey", "ABCDEFGHISDFHJE06566");
            credential.Add("encriptionKey", "ABCDEFGHISSDFSDEWQWE543562145634456543DFHJE06566");

            var result = credential.TryGetValue(key, out string value);

            if (!result)
                throw new ApplicationException("Não foi encontrado valor para a chave buscada");

            return value;
        }
    }
}
