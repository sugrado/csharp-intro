using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ICreditManager
    {
        public void Calculate()
        {
             Console.WriteLine("Mortgage Loan payment plan has been calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
