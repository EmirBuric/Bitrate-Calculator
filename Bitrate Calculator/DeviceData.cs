using Bitrate_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator
{



    public class DeviceData
    {
        public string Device { get; set; }
        public string Model { get; set; }
        public List<NicReading> NIC { get; set; }
    }

    public class NicReading
    {
        public string Description { get; set; }
        public string MAC { get; set; }
        public string Timestamp { get; set; }
        public string Rx { get; set; }
        public string Tx { get; set; }
    }
}


