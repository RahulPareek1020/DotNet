// See https://aka.ms/new-console-template for more information
using SRP.Problem;
using SRP.Solution;

internal class Program
{
    static void Main(string[] args)
    {
        double bonus = 0;

        Employee perEmp = new Employee("Permanent");
        perEmp.Salary = 10000;
        bonus = perEmp.CaculateBonus();
        Console.WriteLine("Bonus for {0} : {1}", "Permanent Employee", bonus);

        Employee contEmp = new Employee("Contract");
        contEmp.Salary = 10000;
        bonus = contEmp.CaculateBonus();
        Console.WriteLine("Bonus for {0} : {1}", "Contract Employee", bonus);

        Console.WriteLine("----------------");

        EmployeeV1 perEmpV1 = new PermanentEmployeeV1();
        perEmpV1.Salary = 10000;
        bonus = perEmpV1.CaculateBonus();
        Console.WriteLine("Bonus for {0} : {1}", "Permanent Employee V1 ", bonus);

        EmployeeV1 contEmpV1 = new ContractEmployeeV1();     
        contEmpV1.Salary = 10000;
        bonus = contEmpV1.CaculateBonus();
        Console.WriteLine("Bonus for {0} : {1}", "Contract Employee V1 ", bonus);

        List<EmployeeV1> list = new List<EmployeeV1>(); 
        list.Add(perEmpV1);
        list.Add(contEmpV1);
    
        Console.ReadLine();
    }
}