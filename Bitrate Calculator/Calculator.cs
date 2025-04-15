using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator
{
    public class Calculator
    {
        private string _x1;
        private string _x2;
        public Calculator(string x1,string x2) 
        {
            _x1 = x1;
            _x2 = x2;
        }

        public void Calc() 
        {
            uint ux1;
            uint ux2;

            int x1=0;
            int x2=0;

            if (uint.TryParse(_x1, out ux1)) 
            {
                x1 = (int)ux1;
            }
            if (uint.TryParse(_x2, out ux2))
            {
                x2 = (int)ux2;
            }

            if (x1<x2)
            {
                int delta=x2-x1;
                int delta_bit = delta * 8;
                double bitrate = delta_bit / 0.5;
                double bitrate_shorten = bitrate / 1000000;
                Console.WriteLine($"Bitrate: {bitrate_shorten} Mbit/s");
            }
        }


    }
}
