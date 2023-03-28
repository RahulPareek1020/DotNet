namespace LSP.Solution.Implementation
{
    public class PermanentEmployeeV2 : EmployeeV2
    {
        public override double CaculateBonus(double salary)
        {
            double bonus = 0.2 * salary;

            return bonus;
        }

        public override double GetMinimumSalary()
        {
            return 100000;
        }
    }
}
