using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Solution
{
    public class PermanentEmployeeV1 : EmployeeV1
    {
        public override double CaculateBonus()
        {
            double bonus = 0.2 * Salary;

            //Console.WriteLine("ContractEmployee bonus " + bonus);
            
            return bonus;
        }
    }
}
