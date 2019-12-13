using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestants contestant = new Contestants();
            SweepStakes SS = new SweepStakes();
            SS.RegisterContestant(contestant);
            SS.RegisterContestant(contestant);
            SS.RegisterContestant(contestant);
            SS.PickWinner();
            Console.WriteLine();
        }
    }
}
