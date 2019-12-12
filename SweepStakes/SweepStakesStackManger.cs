using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    
    class SweepStakesStackManger : ISweepStakesManger
    {
        Stack<string> stack;
        public SweepStakesStackManger()
        {
            stack = new Stack<string>();
        }
        public void InsertSweepstakes()
        {
        }
        public void GetSweepstakes()
        {
        }
    }
}
