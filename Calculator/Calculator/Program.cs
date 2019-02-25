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

			calc.Add(num2);
			Console.WriteLine("Adding {0}, gives {1}", num2, calc.value);

			calc.Multiply(num2);
			Console.WriteLine("Multiplying by {0}, gives {1}", num2, calc.value);

			calc.Subtract(num2);
			Console.WriteLine("Subtracting {0}, gives {1}", num2, calc.value);

			calc.Divide(num2);
			Console.WriteLine("Dividing by {0}, gives {1}", num2, calc.value);
		}
	}
}
