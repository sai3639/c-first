using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.project
{
    class Employeee
    {
        private string empName;
        public int empGrade { private set; get; }
        public Employeee(string empName, int empGrade)
        {
            this.empName = empName;
            this.empGrade = empGrade;         
        }

        public string NameGrade()
        {
            string temp = empName + "(" + empGrade + ")";
            return temp;
        }
    }
}
