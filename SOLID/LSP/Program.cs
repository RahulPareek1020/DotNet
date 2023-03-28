using LSP.Problem;
using LSP.Solution;
using LSP.Solution.Contracts;
using LSP.Solution.Implementation;

internal class Program
{
    static void Main(string[] args)
    {
        double bonus = 0;        
       
        SRP.Solution.EmployeeV1 vendorV1 = new LSP.Problem.VendorsV1();
        vendorV1.Salary = 10000;
        bonus = vendorV1.CaculateBonus();
        Console.WriteLine("Bonus for {0} : {1}", "Vendor Employee ", bonus);

        Console.WriteLine("After Liskov Substitution Principle Implementation");

        EmployeeV2 permanentEmp2 = new LSP.Solution.Implementation.PermanentEmployeeV2();
        permanentEmp2.empName = "Rahul";
        bonus = permanentEmp2.CaculateBonus(permanentEmp2.GetMinimumSalary());
        //Console.WriteLine("Bonus for {0} : {1}", "Vendor Employee ", bonus);

        EmployeeV2 contractEmp2 = new LSP.Solution.Implementation.ContractEmployeeV2();
        contractEmp2.empName = "Pareek";
        bonus = contractEmp2.CaculateBonus(contractEmp2.GetMinimumSalary());
        //Console.WriteLine("Bonus for {0} : {1}", "Vendor Employee ", bonus);

        //EmployeeV2 vendor2 = new LSP.Solution.Vendors();
        //bonus = vendor2.CaculateBonus(5000);
        //Console.WriteLine("Bonus for {0} : {1}", "Vendor Employee ", bonus);

        IEmployee vendor3 = new LSP.Solution.Implementation.VendorsV2();
        vendor3.empName = "test";
        //bonus = vendor2.CaculateBonus();
        //Console.WriteLine("Bonus for {0} : {1}", "Vendor Employee ", bonus);


        List<EmployeeV2> empEligibleForBonusList = new List<EmployeeV2>();
        empEligibleForBonusList.Add(permanentEmp2);
        empEligibleForBonusList.Add(contractEmp2);

        foreach (EmployeeV2 emp in empEligibleForBonusList) {            
            Console.WriteLine("Name : {0}, Min Sal : {1}, Bonus : {2} ", emp.empName, emp.GetMinimumSalary(), emp.CaculateBonus(emp.GetMinimumSalary()));
        }

        Console.WriteLine("------------");
        List <IEmployee> allEmplist = new List<IEmployee>();
        allEmplist.Add(permanentEmp2);
        allEmplist.Add(contractEmp2);
        allEmplist.Add(vendor3);

        foreach (IEmployee emp in allEmplist)
        {            
            Console.WriteLine("Name : {0}, Min Sal: {1} ", emp.empName, emp.GetMinimumSalary());
        }

        Console.ReadLine();
    }
}