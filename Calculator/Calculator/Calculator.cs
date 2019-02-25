namespace Calculator
{
	public class Calculator
	{
		public double value;

		public void Multiply(double num)
		{
			value *= num;
		}

		public void Divide(double num)
		{
			value /= num;
		}

		public void Add(double num)
		{
			value += num;
		}

		public void Subtract(double num)
		{
			value -= num;
		}
	}
}