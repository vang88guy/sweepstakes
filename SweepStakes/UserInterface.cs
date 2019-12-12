using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterface
    {
        public static string FirstName() 
        {
            string firstname;
            Console.WriteLine("Please enter information");
            Console.WriteLine("First Name : ");
            firstname = Console.ReadLine();
            return firstname;
        }
        public static string LastName()
        {
            string lastname;
            Console.WriteLine("Last Name : ");
            lastname = Console.ReadLine();
            return lastname;
        }
        public static string eMail()
        {
            string email;
            Console.WriteLine("E mail : ");
            email = Console.ReadLine();
            return email;
        }
        public static string RegisterNumber()
        {
            string regnumber;
            Console.WriteLine("Registration Number : ");
            regnumber = Console.ReadLine();
            return regnumber;
        }
    }
}
