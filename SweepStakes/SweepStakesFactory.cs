using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class SweepStakesFactory
    {
        
        
      
        public static ISweepStakesManager ChooseManager(int choice)
        {
            ISweepStakesManager sweep;
            //int  choice = UserInterface.PickManager();
            switch (choice) 
            {
                case 1:
                    sweep = new SweepStakesStackManger();
                    return sweep;
                case 2:
                    sweep = new SweepStakesQueueManger();
                    return sweep;
                default:
                    throw new ApplicationException("Wrong choice"); 
            }
            
                
        }
    }
}
