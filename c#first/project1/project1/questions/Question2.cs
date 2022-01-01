using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.questions
{
     public class Question2
    {
        public double salary;
        public double bonus;

       public void CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            Console.WriteLine("Total pay= " + totalPay);
        }
    }
}
