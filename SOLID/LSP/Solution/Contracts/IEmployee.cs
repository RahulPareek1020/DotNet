namespace LSP.Solution.Contracts
{
    public interface IEmployee
    {
        int empId { get; set; }
        string empName { get; set; }

        double GetMinimumSalary();
    }
}
