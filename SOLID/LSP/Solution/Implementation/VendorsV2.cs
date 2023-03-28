using LSP.Solution.Contracts;

namespace LSP.Solution.Implementation
{
    public class VendorsV2 : IEmployee
    {
        public int empId { get; set; }
        public string empName { get; set; }

        public double GetMinimumSalary()
        {
            return 1000;
        }
    }
}
