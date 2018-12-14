using System;

namespace GetMax
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Enter 3 numbers.");
			Console.Write("Enter the first number: ");
			int firstNumber = int.Parse(Console.ReadLine());
			Console.Write("Enter the second number: ");
			int secondNumber = int.Parse(Console.ReadLine());
			Console.Write("Enter the third number: ");
			int thirdNumber = int.Parse(Console.ReadLine());

			
			Console.WriteLine("The biggest number is: " + GetMax(firstNumber, secondNumber, thirdNumber));
		}

			static int GetMax(int number1, int number2, int number3)
		{
			
			if (number1 > number2 && number1 > number3)
			{
				return number1;
			}
			else if (number2 > number1 && number2 > number3)
			{
				return number2;
			}
			else return number3;
		}
	}
}
