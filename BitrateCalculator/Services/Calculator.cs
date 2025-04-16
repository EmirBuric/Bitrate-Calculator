using BitrateCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculator.Services
{
    public class Calculator : ICalculator
    {
        public void Calc(ulong x1, ulong x2, DateTime dx1, DateTime dx2)
        {
            ulong delta = 0;
            if (x1 < x2)
            {
                delta = x2 - x1;
            }
            else
            {
                delta = ulong.MaxValue - x1 + x2;
            }
            double duration = (dx2 - dx1).TotalSeconds;
            ulong delta_bit = delta * 8;
            double bitrate = delta_bit / duration / 1000;
            Console.WriteLine($"{bitrate} kbit/s");
        }


    }
}
