using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork._25._05
{
    public class Student : User
    {
        public string Grade;


        public override void IsUser()
        {
            Console.WriteLine("This student grade is: " + Grade);
        }
    }
}
