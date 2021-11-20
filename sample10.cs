using System;
					
public class Program
{
	public static void Main()
	{
	int numberOne, numberTwo, greaterNumber;

	Console.WriteLine("Please enter two numbers..");
	Console.Write("Enter first number: ");
	numberOne = int.Parse(Console.ReadLine());
	Console.Write("Enter second number: ");
	numberTwo = int.Parse(Console.ReadLine());
		
	if (numberOne > numberTwo)
	{
	 greaterNumber = numberOne;
	}
	else
	{
	 greaterNumber = numberTwo;
	}
	Console.WriteLine("The greater number of the two is " + greaterNumber);

	}
}
