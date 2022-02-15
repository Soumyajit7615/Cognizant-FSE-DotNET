using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    static void Main(String[] args){
        string firstName, lastName;
        
        Console.WriteLine("Enter first name");
        firstName = Console.ReadLine();
        Console.WriteLine("Enter last name");
        lastName = Console.ReadLine();
        
        Console.WriteLine($"Full name : {firstName} {lastName}");
        
    }
}
