namespace LSP.Solution.Implementation
{
    public class ContractEmployeeV2 : EmployeeV2
    {
        public override double CaculateBonus(double salary)
        {
            double bonus = 0.1 * salary;

            return bonus;
        }

        public override double GetMinimumSalary()
        {
            return 50000;
        }
    }
}
