using System;

namespace CS_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string catTag = "Category";
            int studentAmount = 32000;
            double rate = 1.45;
            bool loginStatus = true;
            double yesterday = 7.4;
            double today = 7.5;

            if (yesterday > today)
            {
                Console.WriteLine("decreased");
            }
            else if (yesterday < today)
            {
                Console.WriteLine("increased");
            }
            else
            {
                Console.WriteLine("constant");
            }



            if (loginStatus == true)
            {
                Console.WriteLine("Logged in");
            }
            else
            {
                Console.WriteLine("Not logged in");
            }
            Console.WriteLine(catTag);
        }
    }
}
