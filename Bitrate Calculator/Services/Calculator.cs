using Bitrate_Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator.Services
{
    public class Calculator : ICalculator
    {
        public void Calc(long x1, long x2, DateTime dx1, DateTime dx2)
        {
            long delta = 0;
            if (x1 < x2)
            {
                delta = x2 - x1;
            }
            else
            {
                delta = long.MaxValue - x1 + (long.MinValue - x2);
            }
            double duration = (dx2 - dx1).TotalSeconds;
            long delta_bit = delta * 8;
            if (delta_bit < 0)
            {
                delta_bit += long.MaxValue;
            }
            double bitrate = delta_bit / duration / 1000;
            Console.WriteLine($"Bitrate: {bitrate} kbit/s");
        }


    }
}
