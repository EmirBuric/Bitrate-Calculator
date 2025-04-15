using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator.Interfaces
{
    public interface ICalculator
    {
        public void Calc(long x1, long x2, DateTime dx1, DateTime dx2);
    }
}
