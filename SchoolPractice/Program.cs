using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student newStudent = new Student();
            newStudent.Name = "Kara";
            newStudent.StudentId = 100;
            newStudent.NumberOfCredits = 1;
            newStudent.Gpa = 4.0;
            //Console.WriteLine(newStudent.Name + newStudent.StudentId);

            Student anotherStudent = new Student();
            anotherStudent.Name = "Joe";
            anotherStudent.StudentId = 101;
            anotherStudent.NumberOfCredits = 1;
            anotherStudent.Gpa = 3.5;


            List<Student> someStudents = new List<Student>();
            someStudents.Add(newStudent);
            someStudents.Add(anotherStudent); 
            

            Course newCourse = new Course();

            newCourse.CourseName = "Math101";
            newCourse.Instructor = "Mrs. Smith";
            newCourse.ClassStudents = someStudents;


            Console.WriteLine(newCourse.CourseName);
            Console.WriteLine(newCourse.Instructor);
            Console.WriteLine(newCourse.ClassStudents[0].Name);
        }
    }
}
