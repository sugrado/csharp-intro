using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    class FourOperation
    {
        public void Sum(int num1, int num2)
        {
            int res = num1 + num2;
            Console.WriteLine("Result: " + res);
        }

        public void Minus(int num1, int num2)
        {
            int res = num1 - num2;
            Console.WriteLine("Result: " + res);
        }

        public void Multiply(int num1, int num2)
        {
            int res = num1 * num2;
            Console.WriteLine("Result: " + res);
        }

        public void Divide(int num1, int num2)
        {
            float res = (float)num1 / num2;
            Console.WriteLine("Result: " + res);
        }
    }
}
