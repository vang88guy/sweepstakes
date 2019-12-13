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
            Console.WriteLine("What is the prize of your SweepStakes");
            return Console.ReadLine().ToLower();
        }
        public static string FirstName() 
        {            
            Console.WriteLine("Please enter information");
            Console.WriteLine("First Name : ");
            return Console.ReadLine().ToLower();
        }
        public static string LastName()
        {
            Console.WriteLine("Last Name : ");
            return Console.ReadLine().ToLower();
        }
        public static string eMail()
        {           
            Console.WriteLine("E mail : ");
            return Console.ReadLine().ToLower();        
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
        public static int PickManager()
        {            
            Console.WriteLine("Which Manager system would you like to use, Stack or Queue?" + "\n" +
                              "1: Stack" + "\n" +
                              "2: Queue" + "\n" +
                              "Enter number");
            return Int32.Parse(Console.ReadLine());
        }
            
    }
}
