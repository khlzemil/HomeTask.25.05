using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork._25._05
{
    public class User
    {
        public string Name;
        public string Surname;
        public string Username;
        public string Password;


        public virtual void IsUser()
        {
            Console.WriteLine("This user is not student");
        }
    }

    
}
