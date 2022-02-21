using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx1 //DO NOT CHANGE the namespace name
{
    public class Program //DO NOT CHANGE the class name
    {
        static void Main(string[] args) //DO NOT CHANGE the 'Main' method signature
        {
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            //Implement code here
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", null);
            string dt = dob.ToString("dd-mm-yyyy");
            Console.WriteLine(CalculateAge(dt));
        }

        public static int CalculateAge(string dateOfBirth)
        {
            //Implement code here

            int birthYear = Convert.ToInt32(dateOfBirth.Substring(6, 4));
            int birthMonth = Convert.ToInt32(dateOfBirth.Substring(3, 2));
            int birthDate = Convert.ToInt32(dateOfBirth.Substring(0, 2));
            var today = DateTime.Today;
            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (birthYear * 100 + birthMonth) * 100 + birthDate;
            return (a - b - 400) / 10000;
        }
    }
}
