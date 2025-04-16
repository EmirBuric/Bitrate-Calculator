using Bitrate_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator.Interfaces
{
    public interface IJsonMethods
    {
        public DataStrings LoadJson();
        public DeviceData ManualParse(DataStrings dataStrings);
    }
}
