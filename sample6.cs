using System;
					
public class Program
{
	public static void Main()
	{
		int numberOne, numberTwo, numberThree;
		Console.WriteLine("Please enter three numbers...");

		Console.Write("Enter first number: ");
		numberOne = int.Parse(Console.ReadLine());
		Console.Write("Enter second number: ");
		numberTwo = int.Parse(Console.ReadLine());
		Console.Write("Enter third number: ");
		numberThree = int.Parse(Console.ReadLine());
		int sum = numberOne + numberTwo + numberThree;
		Console.WriteLine("The sum of the three numbers is " + sum);
	}
}
