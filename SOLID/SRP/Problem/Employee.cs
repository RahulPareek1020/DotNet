using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Problem
{
    public class Employee
    {
        public string empType;
        public int empId;
        public int empName;
        public double Salary;      

        public Employee(string empType)
        {
            this.empType = empType;
        }

        public double CaculateBonus() {
            double bonus = 0;

            if (this.empType == "Permanent") {
                bonus = 0.2 * Salary;                
            }
            else if (this.empType == "Contract")
            {
                bonus = 0.1 * Salary;
            }

            return bonus;
        }       
    }
}
