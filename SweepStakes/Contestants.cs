using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{

     public class Contestants
    {
        string firstname;
        string lastname;
        string email;
        int regnumber;
        public string Firstname { get{return firstname;} set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int Regnumber { get { return regnumber; } set { regnumber = value; } }
        public Contestants()
        {
            firstname = "";
            lastname = "";
            email = "";
            regnumber = 0;
        }
        
    }
}
