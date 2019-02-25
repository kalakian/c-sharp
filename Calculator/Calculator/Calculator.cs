namespace Calculator
{
	public class Calculator
	{
		public double value;

		public Calculator Multiply(double num)
		{
			value *= num;

			return this;
		}

		public Calculator Divide(double num)
		{
			value /= num;

			return this;
		}

		public Calculator Add(double num)
		{
			value += num;

			return this;
		}

		public Calculator Subtract(double num)
		{
			value -= num;

			return this;
		}
	}
}