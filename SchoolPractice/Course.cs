using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {

       public string CourseName { get; set; }
       public string Instructor { get; set; }
       public List<Student> ClassStudents { get; set; }

       

        //public Course (string courseName, string instructor, List<Student> classStudents)
        // {
        //     this.CourseName = courseName;
        //     this.Instructor = instructor;
        //     this.ClassStudents = classStudents;
        // }

        // public Course ()
        // {

        // }
    }
}
