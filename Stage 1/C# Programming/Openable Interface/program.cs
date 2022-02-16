using System;

interface IOpenable{
    string OpenSesame();
}

public class TreasureBox : IOpenable{
    public string OpenSesame(){
        return "Congratulations , Here is your lucky win";
    }
}

public class Parachute : IOpenable{
    public string OpenSesame(){
        return "Have a thrilling experience flying in air";
    }
}

class Program{
    static void Main(String[] args){
        
        TreasureBox treasure = new TreasureBox();
        Parachute parachute = new Parachute();
        
        Console.WriteLine(treasure.OpenSesame());
        Console.WriteLine(parachute.OpenSesame());

    }
}
