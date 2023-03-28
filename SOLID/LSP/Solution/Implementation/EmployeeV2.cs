using LSP.Solution.Contracts;

namespace LSP.Solution.Implementation
{
    public abstract class EmployeeV2 : IEmployee, IEmployeeBonus
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public double Salary { get; set; }

        //IEmployee
        public abstract double GetMinimumSalary();

        //IEmployeeBonus
        public abstract double CaculateBonus(double salary);
    }
}
