using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.

            Student student1 = new Student("Kara", 100, 0, 3.0);
            Student student2 = new Student("Kara", 100);

            Console.WriteLine(student1.GetGradeLevel(student1.NumberOfCredits));

            student1.AddGrade(3, 4.0);
            Console.WriteLine(student1.Gpa);
            Console.WriteLine(student1.NumberOfCredits);

            student1.AddGrade(4, 3.5);
            Console.WriteLine(student1.Gpa);
            Console.WriteLine(student1.NumberOfCredits);

            Console.WriteLine(student1.ToString());

            Course testCourse = new Course();

            Console.WriteLine(student1.Equals(student2));

            Console.WriteLine(student1.Equals(testCourse));
        }
    }
}
