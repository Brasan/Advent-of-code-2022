using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Task1
{
	public static void Main()
	{
		int currentCalories = 0;
		string[] inputLines = File.ReadAllLines("1/input.txt");
		List<int> calories = new();

		foreach (string line in inputLines){
			if ( line == "" || Array.IndexOf(inputLines, line) == inputLines.Length - 1)
			{
				calories.Add(currentCalories);
				currentCalories = 0;
				continue;
			}

			currentCalories += int.Parse(line);
				
		}

		calories.Sort();
		calories.Reverse();
		Console.WriteLine("Top elf has " + calories[0]);
        Console.WriteLine("Top three elves have " + Enumerable.Sum(calories.GetRange(0,3)));
        Console.ReadKey();
	}
}
