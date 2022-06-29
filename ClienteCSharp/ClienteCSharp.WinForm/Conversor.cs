
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ClienteCSharp
{
    public class Conversor
    {
        public static string SerializarObjeto(Cliente registro)
        {
            return JsonConvert.SerializeObject(registro, Formatting.Indented);
        }

        private static Cliente DeserealizarObjecto(string json)
        {
            return JsonConvert.DeserializeObject<Cliente>(json);
        }
    }
}
