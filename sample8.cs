using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter a number: ");
		int number = int.Parse(Console.ReadLine());
		bool isDivisibleBy5or7 = number % 5 == 0 || number % 7 == 0;
		Console.WriteLine("Is the number you entered is either divisible by 5 or 7.");
		Console.WriteLine("The answer is " + isDivisibleBy5or7);
	}
}
