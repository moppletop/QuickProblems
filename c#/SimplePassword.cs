using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickProblems_Sharp
{
    class SimplePassword
    {
        public static void Password()
        {
            Console.WriteLine("What is the password?");

            string password = Console.ReadLine();

            if(password.Equals("myPassword"))
            {
                Console.WriteLine("The password is correct");
            }
            else
            {
                Console.WriteLine("The password is incorrect");
            }
        }
    }
}
