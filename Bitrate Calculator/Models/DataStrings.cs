using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator.Models
{
    public class DataStrings
    {
        public string Device { get; set; }
        public string Model { get; set; }
        public List<NICStrings> NIC { get; set; }
    }

    public class NICStrings
    {
        public string Description { get; set; }
        public string MAC { get; set; }
        public string Timestamp { get; set; }
        public string Rx { get; set; }
        public string Tx { get; set; }
    }
}
