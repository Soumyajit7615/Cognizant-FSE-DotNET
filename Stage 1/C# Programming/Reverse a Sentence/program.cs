using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    static void Main(String[] args){
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            String[] splitStrings = str.Split(' ');

            var result = "";
            for (var i = splitStrings.Length - 1; i >= 0; i--)
            {
                result += $"{splitStrings[i]} ";
            }
            Console.WriteLine(result);
    }
}
