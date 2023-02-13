using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class desir
    {
        public static void MySerialeze<T>(T pers)
        {
            string desktop = Environment.GetFolderPath((Environment.SpecialFolder.Desktop));

            string json = JsonConvert.SerializeObject(pers);
            File.WriteAllText(desktop + "/PEOPLE_PASSWORD.json", json);
        }

        public static T MyDesirialize<T>()
        {
            string desktop = Environment.GetFolderPath((Environment.SpecialFolder.Desktop));

            string json = File.ReadAllText(desktop + "/PEOPLE_PASSWORD.json");
            T type = JsonConvert.DeserializeObject<T>(json);
            return type;
        }
    }
}
