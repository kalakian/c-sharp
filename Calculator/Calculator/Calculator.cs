namespace Calculator
{
	public class Calculator
	{
		public double value;

		public double Multiply(double num)
		{
			value *= num;

			return value;
		}

		public double Divide(double num)
		{
			value /= num;

			return value;
		}

		public double Add(double num)
		{
			value += num;

			return value;
		}

		public double Subtract(double num)
		{
			value -= num;

			return value;
		}
	}
}