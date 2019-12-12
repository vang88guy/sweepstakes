using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesQueueManger : ISweepStakesManger
    {
        Queue<string> queue;
        public SweepStakesQueueManger()
        {
            queue = new Queue<string>();
        }

        public void InsertSweepstakes(SweepStakes sweepStakes) 
        { 
        }
        public void GetSweepstakes() 
        { 
        }
    }
}
