using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement               //DO NOT Change the namespace name
{
    public class Program              //DO NOT Change the class name
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Program main = new Program();

            Console.WriteLine("Enter Student Id");
            student.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name");
            student.StudentName = Console.ReadLine();

            Console.WriteLine("Enter Enrollment Date");
            student.EnrolledDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter Department");
            student.Department = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            student.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            main.AddStudent(student);
        }

        public void AddStudent(Student student)
        {
            CollegeContext context = new CollegeContext();

            context.Students.Add(student);

            context.SaveChanges();

            Console.WriteLine("Details Added Successfully");
        }
    }
}
