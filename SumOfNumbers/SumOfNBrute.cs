using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    internal class SumOfNBrute: ISumOfN
    {
        public long SumUntil { get; set; }

        public SumOfNBrute(long SumUntil)
        {
            this.SumUntil = SumUntil;
        }

        public virtual long Calculate()
        {
            long sum = 0;
            for (int i = 1; i <= SumUntil; i++)
            {
                sum = sum + i;
            }

            return sum;
        }
    }
}
