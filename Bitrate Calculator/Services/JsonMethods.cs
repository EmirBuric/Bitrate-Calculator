using Bitrate_Calculator.Interfaces;
using Bitrate_Calculator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator.Services
{
    public class JsonMethods : IJsonMethods
    {
        public DeviceData LoadJson()
        {
            StreamReader r = new StreamReader("Data.json");
            string json = r.ReadToEnd();
            DeviceData items = JsonConvert.DeserializeObject<DeviceData>(json);
            return items;

        }
    }
}
