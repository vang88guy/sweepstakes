using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterface
    {
        public static string SweepStakes() 
        {
            string sweepstakes;
            Console.WriteLine("What is the name of your SweepStakes");
            sweepstakes = Console.ReadLine().ToLower();
            Console.WriteLine();
            return sweepstakes;
        }
        public static string FirstName() 
        {
            string firstname;
            Console.WriteLine("Please enter information");
            Console.WriteLine("First Name : ");
            firstname = Console.ReadLine().ToLower();
            Console.WriteLine();
            return firstname;
        }
        public static string LastName()
        {
            string lastname;
            Console.WriteLine("Last Name : ");
            lastname = Console.ReadLine().ToLower();
            Console.WriteLine();
            return lastname;
        }
        public static string eMail()
        {
            string email;
            Console.WriteLine("E mail : ");
            email = Console.ReadLine().ToLower();
            Console.WriteLine();
            return email;
        }
        public static void RegisterNumber(int number)
        {
           
            Console.WriteLine("Registration Number : " + number);
            Console.WriteLine();
         
        }
        public static void Winner(Contestants contestant) 
        {
            Console.WriteLine("Winner: " + contestant.Firstname +" "+ contestant.Lastname +"\n"+
                               "Email: " + contestant.Email + "\n"+
                               "Registration Number: "+ contestant.Regnumber);
        }
    }
}
