using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperation fourOpr = new FourOperation();
            fourOpr.Sum(5, 6);
            fourOpr.Minus(5, 6);
            fourOpr.Multiply(5, 6);
            fourOpr.Divide(5, 6);
        }
    }
}
