using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calculated Artisan Loan.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
