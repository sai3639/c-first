using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.project
{
     class Company
    {
        static void Main()
        {
            Employeee alex = new Employeee("Alex", 7);
            Department sales = new Department("X Sales");
            sales.AddEmployee(alex);
            sales.describe();
        }
    }
}
