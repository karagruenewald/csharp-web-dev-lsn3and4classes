using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            double qualityScore = courseCredits * grade;

            double totalQualityScore = (this.Gpa * this.NumberOfCredits) + qualityScore;

            int newCreditTotal = this.NumberOfCredits + courseCredits;
            this.Gpa = totalQualityScore / newCreditTotal;
            this.NumberOfCredits = newCreditTotal;


            // Update the appropriate properties: NumberOfCredits, Gpa
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            
            if (credits >= 90)
            {
                return "Senior";
            }
            else if (credits >= 60)
            {
                return "Junior";
            }
            else if (credits >= 30)
            {
                return "Sophmore";
            }
            else
            {
                return "Freshman";
            }

        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        public override string ToString()
        {
            string output = "Student info:\n Name: " + this.Name + "\n GPA: " + this.Gpa + "\n ID: " + this.StudentId + "\n Credits: " + this.NumberOfCredits;
            return output;
                }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Student toCompare = obj as Student;

            return this.Name == toCompare.Name && this.StudentId == toCompare.StudentId;
        }
    }
}
