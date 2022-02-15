using System;


namespace JaggedArray      //DO NOT Change the namespace name
{
    public class Program    //DO NOT Change the class name
    {
        public static void Main(string[] args)    //DO NOT change the method signature
        {
	        //Implement code here
	        // Get input from the user and construct a jagged array
	                    Console.WriteLine("Enter the number of teams:");
            int noOfTeams = Convert.ToInt32(Console.ReadLine());

            int[][] teamsArray = new int[noOfTeams][];

            for (int i = 0; i < noOfTeams; i++)
            {
                Console.WriteLine($"No.of attempts for team {i + 1}:");
                int teamAttempts = Convert.ToInt32(Console.ReadLine());
                teamsArray[i] = new int[teamAttempts];
            }

            for (int i = 0; i < teamsArray.Length; i++)
            {
                Console.WriteLine($"Enter the score for team {i + 1}:");
                for (int j = 0; j < teamsArray[i].Length; j++)
                {
                    teamsArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine(GetTotalScore(teamsArray));
        }
        
        public static String GetTotalScore(int[][] arrayTeams)        //DO NOT change the method signature
        {
            //Implement code here 
            //Method to calculate total score for each team and return a string as specified in the sample output.
            String result = "";
            for (int i = 0; i < arrayTeams.Length; i++)
            {
                int totalScore = 0;
                for (int j = 0; j < arrayTeams[i].Length; j++)
                {
                    totalScore += arrayTeams[i][j];
                }

                result += $"Team {i} Total Score is {totalScore} . ";
            }
            return result;
        }

    }
}
