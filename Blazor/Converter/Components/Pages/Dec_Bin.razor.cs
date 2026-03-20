

namespace Converter.Components.Pages
{
	public partial class Dec_Bin
	{

		int dec;
		string bin;
		public void DecToBin()
		{
			try
			{
				bin = Convert.ToString(dec, 2);
			}
			catch (Exception e)
			{
				dec = 0;
				bin = "";
				PrintError(e.ToString());
			}
		}

		public void BinToDec()
		{
			try
			{
				dec = bin.Length > 0 ? Convert.ToInt32(bin,2) : 0;
			}
			catch (Exception e)
			{
				dec = 0;
				bin = "";
				PrintError(e.ToString());
			}
		}

		public void PrintError(string msg)
		{
			Console.WriteLine(msg);
		}

	}
}
