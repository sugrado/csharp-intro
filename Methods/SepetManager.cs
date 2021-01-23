using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        public void Add(Product prod)
        {
            Console.WriteLine("Congratulations. Product added to cart: " + prod.Name);
        }

        //Useless Example
        /*
        public void Add2(string prodName, string desc, double price)
        {
            Console.WriteLine("Congratulations. Product added to cart: " + prodName);
        }
        */
    }
}