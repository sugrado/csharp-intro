using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        public void Add(Product urun)
        {
            Console.WriteLine("Congratulations. Product added to cart: " + urun.Name);
        }

        //Useful Example
        /*
        public void Add2(string prodName, string desc, double price)
        {
            Console.WriteLine("Congratulations. Product added to cart: " + prodName);
        }
        */
    }
}