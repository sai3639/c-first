using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.constructor
{
    class Construct
    {
        public int length;
        public int width;


        public Construct()
        {
            length = 6;
            width = 5;
            Console.WriteLine("Constructor fired");
        }
        public void CalculateArea()
        {
            Console.WriteLine("Area =  " + (length * width));

        }
    }
}
