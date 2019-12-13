using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    
    class SweepStakesStackManger : ISweepStakesManger
    {
        Stack<SweepStakes> stack;
        SweepStakes sweepStakes;
        public SweepStakesStackManger()
        {
            
            stack = new Stack<SweepStakes>();
        }
        public void InsertSweepstakes(SweepStakes sweepStakes)
        {
            sweepStakes = new SweepStakes();
            stack.Push(sweepStakes);
        }
        public SweepStakes GetOutSweepstakes()
        {
            sweepStakes = stack.Pop();
            return sweepStakes;
        }
    }
}
