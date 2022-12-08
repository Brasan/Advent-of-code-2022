using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace aoc2022._2
{
    internal class Task2
    {

        readonly static string[] pointsValuesAsIndex = { "", "B X", "C Y", "A Z", "A X", "B Y", "C Z", "C X", "A Y", "B Z" };
        readonly static string[] pointsValuesAsIndexPart2 = { "", "B X", "C X","A X", "A Y","B Y","C Y","C Z","A Z", "B Z"};
        public static void Main()
        {
            int playerPoints = 0;
            int playerPointsPart2 = 0;
            string[] inputLines = File.ReadAllLines("2/input.txt");
           
            foreach (string line in inputLines)
            {
                if (line == "")
                {
                    continue;
                }
                playerPoints += Array.IndexOf(pointsValuesAsIndex, line);
                playerPointsPart2 += Array.IndexOf(pointsValuesAsIndexPart2, line);

            }

            Console.WriteLine("You got a total of " + playerPoints.ToString() + " points in part 1");
            Console.WriteLine("You got a total of " + playerPointsPart2.ToString() + " points in part 2");
        }

        
    }
}
