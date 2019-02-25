using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			var addVal = 1.5;
			var mulVal = 2.6;
			var divVal = 0.3;
			var subVal = 3.2;

			var calc = new Calculator();
			Console.WriteLine("{0} + {1} * {2} - {3} / {4} = {5}",
				calc.value, addVal, mulVal, subVal, divVal,
				calc.Add(addVal).Multiply(mulVal).Subtract(subVal).Divide(divVal).value);
			Console.WriteLine("(Left to Right, no operator precedence)\n");
		}
	}
}
