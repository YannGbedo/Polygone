using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygoneV2
{
    class JsonFile
    {
        public const string JsonUri = "./Polygone.json";
        public static List<Polygone> RecupereList()
        {
            string Contenue = File.ReadAllText(JsonUri).Replace('\'', ' ');
            return JsonConvert.DeserializeObject<List<Polygone>>(Contenue);
        }
        public static void EcrisFile()
        {
            string JsonContenu = JsonConvert.SerializeObject(Polygone.PolygoneConnue);
            File.WriteAllText(JsonUri, JsonContenu);
        }
        public static void ResetFile()
        {
            Polygone.PolygoneConnue = new List<Polygone>();
            File.WriteAllText(JsonUri, "");
        }
    }
}
