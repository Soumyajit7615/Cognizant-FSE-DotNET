using System;

public class Calculator
{
    public int Addition(int a, int b)
    {
        return a + b;
    }

    public int Subtraction(int a, int b)
    {
        return a - b;
    }

    public int Multiplication(int a, int b)
    {
        return a * b;
    }

    public double Division(int a, int b, out double remainder)
    {
        remainder = a % b;
        return a / b;
    }
}

public class Program
{
    static void Main(String[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Enter the operator");
        char ch = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter the operands");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        switch (ch)
        {
            case '+':
                Console.WriteLine($"Result of {a} {ch} {b} is {calc.Addition(a, b)}");
                break;
            case '-':
                Console.WriteLine($"Result of {a} {ch} {b} is {calc.Subtraction(a, b)}");
                break;
            case '*':
                Console.WriteLine($"Result of {a} {ch} {b} is {calc.Multiplication(a, b)}");
                break;
            case '/':
                double remainder;
                Console.WriteLine($"Result of {a} {ch} {b} is {calc.Division(a, b, out remainder)}\nRemainder = {remainder}");
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}
