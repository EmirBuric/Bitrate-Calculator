using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculator.Models
{
    public class NetworkInterfaceCard
    {
        public string Description { get; set; }
        public string MAC { get; set; }
        public DateTime Timestamp { get; set; }
        public ulong Rx { get; set; }
        public ulong Tx { get; set; }
    }
}
