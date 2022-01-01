using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.project
{
     class Department
    {
        private string deptName;
        private double deptBudget;
        private int counter = 0;

        Employeee[] employees = new Employeee[5];
        public void AddEmployee(Employeee obj)
        {
            employees[counter] = obj;
            counter++;
            if (obj.empGrade >= 5)
            {
                this.deptBudget += 1500;
            }
            else
            {
                this.deptBudget += 1000;
            }
        }
        public void describe()
        {
            string temp = "For Department " + this.deptName + " the total budget is " + this.deptBudget + "\nEmployees: ";
            //Console.WriteLine(temp);
            foreach (Employeee t in employees)
            {
                if (t!= null)
                {
                    temp += t.NameGrade();
                }
                
            }
        }
        public Department(string deptName)
        {
            this.deptName = deptName;
            this.deptBudget = 50000;
        }
    }
}
