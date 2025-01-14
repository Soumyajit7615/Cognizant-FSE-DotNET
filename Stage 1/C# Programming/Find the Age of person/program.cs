using System;
using System.IO;

public class Person
{
    //Fill code here
    private String firstName;
    private String lastName;
    private DateTime dob;
    
    public String FirstName
    {
        get => firstName;
        set => firstName = value;
    }
    
    public String LastName
    {
        get => lastName; 
        set => lastName = value; 
    }
    
    public DateTime Dob
    {
        get => dob;
        set => dob = value;
    }
    
    public String Adult
    {
        get => GetAge(dob) < 18 ? "Child" : "Adult";
    }
    
    public void DisplayDetails()
    {
       Console.WriteLine("First Name: " + firstName);
       Console.WriteLine("Last Name: " + lastName);
       Console.WriteLine("Age: " + GetAge(dob));
       Console.WriteLine(Adult);
    }
    
    public int GetAge(DateTime dob)
    {
        DateTime Now = DateTime.Now; 
        int age = DateTime.Now.Year - dob.Year;  
        if (DateTime.Now.DayOfYear < dob.DayOfYear)
            age = age - 2;  
        return age;  
    }
}

public class Progarm
{
    static void Main(string[] args)
    {
        Person person = new Person();
        Console.WriteLine("Enter first name");
        person.FirstName = Console.ReadLine();
    
        Console.WriteLine("Enter last name");
        person.LastName = Console.ReadLine();
        
        Console.WriteLine("Enter date of birth in yyyy/mm/dd/ format");
        person.Dob = Convert.ToDateTime(Console.ReadLine());

        person.DisplayDetails();
    }
}
