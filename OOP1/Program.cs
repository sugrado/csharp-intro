using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Pen", UnitPrice = 35};
            
            //PascalCase //camelCase
            //case sensivite
            ProductManager productManager = new ProductManager();
            //string name = "Gorkem";

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Sum2(3, 6);

            int sumRes = productManager.Sum(3, 6);
            Console.WriteLine(sumRes*2);

            /*
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            //product1.ProductName?? Camera
            Console.WriteLine(product1.ProductName);
            int num = 100;
            productManager.DoSomething(num);
            //num??
            Console.WriteLine(num); //100
            */
        }
    }
}
