using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.Coursename = "C#";
            course1.Egitmen = "Onur alan";
            course1.Izlenmeoranı = 85;

            Course course2 = new Course();
            course2.Coursename = "Python";
            course2.Egitmen = "Onur alan";
            course2.Izlenmeoranı = 84;

            Course course3 = new Course();
            course3.Coursename = "C++";
            course3.Egitmen = "Onur alan";
            course3.Izlenmeoranı = 83;

            Course[] courses = new Course[] { course1, course2, course3 };
            
            
            foreach (var course in courses)
            {
                Console.WriteLine(course.Coursename + " : " +course.Egitmen);
            }


        }


        class Course
        {
            public string Coursename { get; set; }
            public string Egitmen { get; set; }
            public int Izlenmeoranı { get; set; }

        }
        
        


    }
}
