using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added.");
        }
        
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public void Sum2(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        /*
        public void DoSomething(int num)
        {
            num = 99;
        }
        */
    }
}
