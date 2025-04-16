using BitrateCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculator.Interfaces
{
    public interface IJsonMethods
    {
        public DataStrings LoadJson();
        public DeviceData ManualParse(DataStrings dataStrings);
    }
}
