using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Finance Credit payment plan has been calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
