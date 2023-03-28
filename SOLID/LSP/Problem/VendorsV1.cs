using SRP.Solution;

namespace LSP.Problem
{
    public class VendorsV1 : EmployeeV1
    {
        public override double CaculateBonus()
        {
            //We can return 0 from here
            return 0;
            //We can trrow an exception
            //throw new NotImplementedException();    
        }
    }
}
