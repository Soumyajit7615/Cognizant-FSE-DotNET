using System;

public class Account{
    private int id;
    private string accountType;
    private double balance;
    
    public int Id{
        get => id;
        set => id = value;
    }
    
    public string AccountType{
        get => accountType;
        set => accountType = value;
    }
    
    public double Balance{
        get => balance;
        set => balance = value;
    }
    
    public Account(){}
    
    public Account(int id, string accountType, double balance){
        this.id = id;
        this.accountType = accountType;
        this.balance = balance;
    }

    public bool WithDraw(double amount)
    {
        if (balance > amount)
        {
            balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public String GetDetails()
    {
        return $"Account Id: {id}\nAccount Type: {accountType}\nBalance: {balance}";
    }
    
}

public class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter account id");
        var id = Convert.ToInt32(Console.ReadLine());        
        Console.WriteLine("Enter account type");
        var accountType = Console.ReadLine();
        Console.WriteLine("Enter account balance");
        var balance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter amount to withdraw");
        var withdraw = Convert.ToDouble(Console.ReadLine());

        var myAccount = new Account(id, accountType, balance);

        Console.WriteLine(myAccount.GetDetails());

        if (myAccount.WithDraw(withdraw))
        {
            Console.WriteLine($"New Balance : {myAccount.Balance}");
        }
    }
}
