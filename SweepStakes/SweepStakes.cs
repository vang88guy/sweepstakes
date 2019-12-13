using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        Dictionary<int, Contestants> people; 
        string name;

        Contestants contestant;
        public SweepStakes()
        {
            name = "";
            contestant = new Contestants();
            people = new Dictionary<int, Contestants>();
            SweepstakeName();
       
        }
        public void SweepstakeName() 
        {
            name = UserInterface.SweepStakes();
        }
        //public string FirstName() 
        //{
        //   return contestant.Firstname = UserInterface.FirstName();
        //}
        //public string LastName()
        //{
        //   return contestant.Lastname = UserInterface.LastName();
        //}
        //public string EMail() 
        //{
        //   return contestant.Email = UserInterface.eMail();
        //}
        //public string RegNumber() 
        //{
        //    return contestant.Regnumber = UserInterface.RegisterNumber();
        //}
        
        public void RegisterContestant(Contestants contestant)
        {
            int reg;
            contestant.Firstname = UserInterface.FirstName();
            contestant.Lastname = UserInterface.LastName();
            contestant.Email = UserInterface.eMail();
            contestant.Regnumber = (people.Count + 1);
            reg = contestant.Regnumber;
            UserInterface.RegisterNumber(reg);
            people.Add(contestant.Regnumber, contestant);
        }
        public  void PickWinner() 
        {         
            Random random = new Random(); 
            contestant = (people[random.Next((people.Count)+1)]);            
        }
        public void PrintContestantInfo(Contestants contestant) 
        {
            UserInterface.Winner(contestant);
        }

    }
}
