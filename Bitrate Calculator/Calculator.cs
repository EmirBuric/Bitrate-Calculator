using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator
{
    public class Calculator
    {
        public void Calc(long x1, long x2,DateTime dx1,DateTime dx2) 
        {
            long delta = 0;
            if (x1<x2)
            {
                delta=x2-x1;
            }
            double duration=(dx2 - dx1).TotalSeconds;
            long delta_bit = delta * 8;
            double bitrate = delta_bit / duration;
            double bitrate_shorten = bitrate / 1000;
            Console.WriteLine($"Bitrate: {bitrate_shorten} kbit/s");
        }


    }
}
