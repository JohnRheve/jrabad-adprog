using System;
					
public class Program
{
	public static void Main()
	{
	int numberOne, numberTwo, numberThree;
	int greaterNumber = 0;
		
	Console.WriteLine("Please enter two numbers..");
	Console.Write("Enter first number: ");
	numberOne = int.Parse(Console.ReadLine());
		
	Console.Write("Enter second number: ");
	numberTwo = int.Parse(Console.ReadLine());
		
	Console.Write("Enter third number: ");
	numberThree = int.Parse(Console.ReadLine());
		
	if (numberOne > numberTwo && numberOne > numberThree)
	{
		greaterNumber = numberOne;
	}
	else if (numberTwo > numberOne && numberTwo > numberThree)
	{
		greaterNumber = numberTwo;
	}
	else if (numberThree > numberOne && numberThree > numberTwo)
	{
		greaterNumber = numberThree;
	}
	Console.WriteLine("The greater number of the three is " + greaterNumber);
	}
}
