using System;
using System.Collections.Generic;

namespace BallsBowled        //DO NOT change the namespace name
{
    public class Program    //DO NOT change the class name
    {
        static void Main(string[] args)
        {
            //Implement code here
            Console.WriteLine("Enter the number of overs");
            int overs = Convert.ToInt32(Console.ReadLine());

            PlayerBO playerBo = new PlayerBO();
            playerBo.AddOversDetails(overs);
        }
    }

    public class PlayerBO      //DO NOT change the class name
    {
        public List<int> PlayerList { get; set; } = new List<int>();
        int overs;

        public void AddOversDetails(int oversBowled)       //DO NOT change the method signature
        {
            //Implement code here
            PlayerList.Add(oversBowled);
            foreach(int i in PlayerList){
                overs = i;
            }
            Console.WriteLine($"Balls Bowled : {GetNoOfBallsBowled()}");
        }

        public int GetNoOfBallsBowled()              //DO NOT change the method signature
        {
            //Implement code here
            
            return overs * 6;
        }


    }
}
