

namespace Converter.Components.Pages
{
	public partial class Bin_Hex
	{

		int dec;
		string bin, hex;
		public void HexToBin()
		{
			try
			{
				dec = hex.Length > 0 ? Convert.ToInt32(hex, 16) : 0;
				bin = Convert.ToString(dec, 2);
			}
			catch (Exception e)
			{
				dec = 0;
				bin = hex = "";
				PrintError(e.ToString());
			}
		}

		public void BinToHex()
		{
			try
			{
				dec = bin.Length > 0 ? Convert.ToInt32(bin, 2) : 0;
				hex = Convert.ToString(dec, 16);
			}
			catch (Exception e)
			{
				dec = 0;
				bin = hex = "";
				PrintError(e.ToString());
			}
		}

		public void PrintError(string msg)
		{
			Console.WriteLine(msg);
		}

	}
}
