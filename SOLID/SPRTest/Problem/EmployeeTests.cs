using SRP.Problem;

namespace SPRTest
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            double perEmpBonus = 2000;
            double tempEmpBonus = 1000;

            Employee perEmp = new Employee("Permanent");
            perEmp.Salary = 10000;            
            Assert.AreEqual(perEmpBonus, perEmp.CaculateBonus());

            Employee contEmp = new Employee("Contract");
            contEmp.Salary = 10000;
            Assert.AreEqual(tempEmpBonus, contEmp.CaculateBonus());
        }
    }
}