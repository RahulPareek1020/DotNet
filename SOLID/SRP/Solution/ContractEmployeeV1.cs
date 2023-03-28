using SRP.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Solution
{
    public class ContractEmployeeV1 : EmployeeV1
    {
        public string ParentCompany;

        public override double CaculateBonus()
        {
            double bonus = 0.1 * Salary;

            //Console.WriteLine("ContractEmployee bonus " + bonus);
            return bonus;
        }
    }
}
