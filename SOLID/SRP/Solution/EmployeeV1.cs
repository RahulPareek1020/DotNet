using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Solution
{
    public abstract class EmployeeV1
    {
        public string empType;
        public int empId;
        public string empName;
        public double Salary;

        public abstract double CaculateBonus();
    }
}
