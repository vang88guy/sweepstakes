using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesQueueManger : ISweepStakesManager
    {
        Queue<SweepStakes> queue;
        SweepStakes sweepStakes;
        public SweepStakesQueueManger()
        {
            queue = new Queue<SweepStakes>();
        }

        public void InsertSweepstakes(SweepStakes sweepStakes) 
        {
            sweepStakes = new SweepStakes();
            queue.Enqueue(sweepStakes);
        }
        public SweepStakes GetOutSweepstakes() 
        {
            sweepStakes = queue.Dequeue();
            return sweepStakes;
        }
    }
}
