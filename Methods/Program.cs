using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod1 = new Product();
            prod1.Name = "Apple";
            prod1.Price = 15;
            prod1.Description = "Big Apple";

            Product prod2 = new Product();
            prod2.Name = "Watermelon";
            prod2.Price = 80;
            prod2.Description = "Red Watermelon";

            Product[] products = new Product[] { prod1, prod2 };

            foreach (Product prod in products)
            {
                Console.WriteLine(prod.Name);
                Console.WriteLine(prod.Price);
                Console.WriteLine(prod.Description);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("----------Methods-----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(prod1);
            sepetManager.Add(prod2);

            //Useless Example
            /*
            sepetManager.Add2("Armut", "Yesil armut", 12);
            sepetManager.Add2("Elma", "Yesil elma", 12);
            sepetManager.Add2("Karpuz", "Yesil karpuz", 12);
            */
        }
    }
}
