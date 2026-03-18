using System.Numerics;

namespace Blazor.Components.Pages
{
	public partial class Fib
	{
		int number;
		List<BigInteger> results = new List<BigInteger>();

		void setNumber(int number)
		{
			this.number = number;
		}
		void Calculate()
		{
			results = new List<BigInteger> {0,1};

			for (int i = 2; i < number; i++)
			{
				BigInteger result = results[i-1] + results[i-2];
				results.Add(result);
			}
		}
	}
}
