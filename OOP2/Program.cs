using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gorkem Arik

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Gorkem";
            customer1.Surname = "Arik";
            customer1.IdentNumber = "12345678910";


            //Company0

            LegalEntity customer2 = new LegalEntity();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Company0";
            customer2.TaxNumber = "1234657980";

            //Real Customer - Legal Customer
            //SO(L)ID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new LegalEntity();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
