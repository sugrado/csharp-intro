using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* define an array */
            string[] courses = new string[] { "Software Developer Couse", "Introduction to programming course", "java", "python", "c#" };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("Finished for loop.\n");
            foreach (string course in courses) // The foreach construct is used in arrays.
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("While loop.");

            int num, sum = 0, count = 0;

            while (true)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == -1) break;
                sum += num;

                count++;


            }

            double avg = (double)sum / count;
            Console.WriteLine(avg);
            Console.WriteLine("Footer");
        }
    }
}
