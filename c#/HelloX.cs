using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickProblems_Sharp
{
    class HelloX
    {
        public static void SayHelloX()
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }

    }
}
