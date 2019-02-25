using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			var num1 = 1;
			var num2 = 2;

			Console.WriteLine("{0} * {1} = {2}", num1, num2, Calculator.Multiply(num1, num2));
			Console.WriteLine("{0} / {1} = {2}", num1, num2, Calculator.Divide(num1, num2));
			Console.WriteLine("{0} + {1} = {2}", num1, num2, Calculator.Add(num1, num2));
			Console.WriteLine("{0} - {1} = {2}", num1, num2, Calculator.Subtract(num1, num2));
		}
	}
}
