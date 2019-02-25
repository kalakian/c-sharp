using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			var num1 = 1.5;
			var num2 = 2.6;

			var calc = new Calculator {value = num1};
			Console.WriteLine("Starting value is " + calc.value);

			Console.WriteLine("Adding {0}, gives {1}", num2, calc.Add(num2));
			Console.WriteLine("Multiplying by {0}, gives {1}", num2, calc.Multiply(num2));
			Console.WriteLine("Subtracting {0}, gives {1}", num2, calc.Subtract(num2));
			Console.WriteLine("Dividing by {0}, gives {1}", num2, calc.Divide(num2));
		}
	}
}
