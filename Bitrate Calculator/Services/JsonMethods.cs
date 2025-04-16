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
        public DataStrings LoadJson()
        {
            StreamReader r = new StreamReader("Data.json");
            string json = r.ReadToEnd();
            DataStrings items = JsonConvert.DeserializeObject<DataStrings>(json);
            return items;

        }

        public DeviceData ManualParse(DataStrings dataStrings)
        {
            List<NetworkInterfaceCard> networkInterfaces = new List<NetworkInterfaceCard>();
            for (int i = 0; i < dataStrings.NIC.Count; i++)
            {
                NetworkInterfaceCard networkInterface = new NetworkInterfaceCard();

                networkInterface.Description = dataStrings.NIC[i].Description;
                networkInterface.MAC = dataStrings.NIC[i].MAC;
                networkInterface.Timestamp = DateTime.Parse(dataStrings.NIC[i].Timestamp);

                ulong uTx;

                if (ulong.TryParse(dataStrings.NIC[i].Tx, out uTx))
                {
                    networkInterface.Tx = (long)uTx;
                }

                ulong uRx;

                if (ulong.TryParse(dataStrings.NIC[i].Rx, out uRx))
                {
                    networkInterface.Rx = (long)uRx;
                }
                networkInterfaces.Add(networkInterface);

            }

            DeviceData device = new DeviceData();

            device.Device = dataStrings.Device;
            device.Model = dataStrings.Model;
            device.NIC = networkInterfaces;

            return device;


        }
    }
}
