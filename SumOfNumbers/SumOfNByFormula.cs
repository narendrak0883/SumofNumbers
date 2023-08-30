using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    internal class SumOfNByFormula : SumOfNBrute
    {
        public SumOfNByFormula(long sumUntil) : base(sumUntil) { }

        public override long Calculate()
        {
            return SumUntil * (SumUntil + 1) / 2;
        }
    }
}
