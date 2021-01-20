using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gorkem";
            int yas = 18;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Gorkem Ridvan";
            course1.WatchingRate = 36;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Instructor = "Name0 Surname0";
            course2.WatchingRate = 78;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Instructor = "Name1 Surname1";
            course3.WatchingRate = 78;

            Course course4 = new Course();
            course4.CourseName = "C++";
            course4.Instructor = "Name2 Surname2";
            course4.WatchingRate = 100;

            //Console.WriteLine(course.CourseName + " : " + course1.Instructor);

            Course[] kurslar = new Course[] { course1, course2, course3, course4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.CourseName);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int WatchingRate { get; set; }
    }
}
