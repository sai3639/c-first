using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1.questions;

namespace project1.questions
{
    internal class Employee
    {
        static void Main()
        {
            Question2 alex = new Question2();
            

            alex.salary = 9000;
            alex.bonus = 2000;

            alex.CalculateTotalPay();
        }
    }
}
