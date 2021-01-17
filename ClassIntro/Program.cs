using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gorkem";
            int yas = 18;

            Kurs course1 = new Kurs();
            course1.CourseName = "C#";
            course1.Instructor = "Gorkem Ridvan";
            course1.WatchingRate = 36;

            Kurs course2 = new Kurs();
            course2.CourseName = "Java";
            course2.Instructor = "Name0 Surname0";
            course2.WatchingRate = 78;

            Kurs course3 = new Kurs();
            course3.CourseName = "Python";
            course3.Instructor = "Name1 Surname1";
            course3.WatchingRate = 78;

            Kurs course4 = new Kurs();
            course4.CourseName = "C++";
            course4.Instructor = "Name2 Surname2";
            course4.WatchingRate = 100;

            //Console.WriteLine(course.CourseName + " : " + course1.Instructor);

            Kurs[] kurslar = new Kurs[] { course1, course2, course3, course4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.CourseName);
            }
        }
    }

    class Kurs
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int WatchingRate { get; set; }
    }
}
