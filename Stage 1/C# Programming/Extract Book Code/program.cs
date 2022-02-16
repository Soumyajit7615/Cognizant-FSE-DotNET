using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBookCode //Do not change the namespace name
{
    public class Program //Do not change the class name
    {
        public static void Main(String[] arg) //Do not change the method signature
        {
            //Implement code here
            Console.WriteLine("Enter the book code of length 18");
            var bookCode = Console.ReadLine();

            if (bookCode.Length == 18)
            {
                var departmentCode = bookCode.Substring(0, 3);

                Console.WriteLine(departmentCode == "101" || departmentCode == "102" || departmentCode == "103"
                    ? $"Department Code : {departmentCode}"
                    : "Invalid Department Code");
                
                var yearOfPublication = Convert.ToInt32(bookCode.Substring(3, 4));
                Console.WriteLine(yearOfPublication >= 1900 && yearOfPublication <= 2020
                    ? $"Year of Publication : {yearOfPublication}"
                    : "Invalid Year");
                    
                var pageNumber = Convert.ToInt32(bookCode.Substring(7, 5));
                Console.WriteLine(pageNumber >= 00001 && pageNumber <= 99999
                    ? $"Number of Pages : {pageNumber}"
                    : "Invalid Page Numbers");
                
                var bookId = Convert.ToChar(bookCode.Substring(12, 1));
                if (Char.IsLetter(bookId))
                {
                    if (Char.IsNumber(Convert.ToChar(bookCode.Substring(13, 1))) &&
                        Char.IsNumber(Convert.ToChar(bookCode.Substring(14, 1))) &&
                        Char.IsNumber(Convert.ToChar(bookCode.Substring(15, 1))) &&
                        Char.IsNumber(Convert.ToChar(bookCode.Substring(16, 1))) &&
                        Char.IsNumber(Convert.ToChar(bookCode.Substring(17, 1))))
                    {
                        Console.WriteLine($"Book ID : {bookCode.Substring(12, 6)}");
                    }
                    else
                        Console.WriteLine("Invalid Book ID");
                }
                else
                    Console.WriteLine("Invalid Book ID");
            }
            else
            {
                Console.WriteLine("Invalid Book Code");
            }
        }
    }
}
