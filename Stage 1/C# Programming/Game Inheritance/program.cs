using System;

public class Game
{
    public string Name { get; set; }
    public int MaxNumPlayers { get; set; }
    
    public override string ToString()
    {
        return ("Maximum number of players for " + Name + " is " + MaxNumPlayers);
    }
}

public class GameWithTimeLimit : Game
{
    public int TimeLimit { get; set; }
    
    public override string ToString()
    {
        Console.WriteLine(base.ToString());
        return ("Time Limit for " + Name + " is " + TimeLimit + " minutes");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Game game = new Game();
        GameWithTimeLimit gameWithTime = new GameWithTimeLimit();
        
        Console.WriteLine("Enter a game");
        game.Name = Console.ReadLine();
        
        Console.WriteLine("Enter the maximum number of players");
        game.MaxNumPlayers = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter a game that has time limit");
        gameWithTime.Name = Console.ReadLine();
        
        Console.WriteLine("Enter the maximum number of players");
        gameWithTime.MaxNumPlayers = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the time limit in minutes");
        gameWithTime.TimeLimit = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(game.ToString());
        Console.WriteLine(gameWithTime.ToString());
    }
}
