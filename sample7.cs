using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter a number: ");
		int number = int.Parse(Console.ReadLine());
		bool isOdd = number % 2 == 1;
		Console.WriteLine
		("The number is ODD. True or False? Answer is: " + isOdd);
	}
}
