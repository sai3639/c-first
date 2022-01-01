using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.day1
{
     class Example1
    {
        static void Main()
        {
            string x = "One";
            switch(x)
            {
                case "Zero":
                    Console.WriteLine(" value is 0");
                    break;
                case "One":
                    Console.WriteLine(" value is one");
                    break;
                case "Two":
                    Console.WriteLine(" value is 2");
                    break;
                default:
                    Console.WriteLine(" value not found");
                    break;
            }
        }
    }
}
