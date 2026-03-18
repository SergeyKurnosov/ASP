using System.Numerics;

namespace Blazor.Components.Pages
{
	public partial class Power
	{
		int number;
		int exponent;

		BigInteger result = 1;
		void setNumber(int number)
		{
			this.number = number;
		}
		void Calculate()
		{
			result = (BigInteger)Math.Pow(this.number, this.exponent);
		}
	}
}
