﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public interface ISweepStakesManager
    {
       void InsertSweepstakes(SweepStakes sweepStakes);
       SweepStakes GetOutSweepstakes();
    }
}
