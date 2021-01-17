using System;

namespace ValueAndReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //int, decimal, float, double, bool = value type
            //array, class, interface = referance type
            Console.WriteLine("Hello World!");

            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            //num1=?? 30

            int[] nums1 = new int[] { 10, 20, 30 };
            int[] nums2 = new int[] { 100, 200, 300 };
            nums1 = nums2;
            nums2[0] = 999;
            //nums1[0]=?? 999
        }
    }
}
