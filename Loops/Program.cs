using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = new string[] { "course1", "course2", "course3" };
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("footer");
            
            
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }


        }
    }
}
