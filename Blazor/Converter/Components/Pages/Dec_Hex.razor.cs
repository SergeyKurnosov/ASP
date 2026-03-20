

namespace Converter.Components.Pages
{
	public partial class Dec_Hex
	{

		int dec;
		string hex;
		public void DecToHex()
		{
			try
			{
				hex = Convert.ToString(dec, 16);
			}
			catch (Exception e)
			{
				dec = 0;
				hex = "";
				PrintError(e.ToString());
			}
		}

		public void HexToDec()
		{
			try
			{
				dec = hex.Length > 0 ? Convert.ToInt32(hex,16) : 0;
			}
			catch (Exception e)
			{
				dec = 0;
				hex = "";
				PrintError(e.ToString());
			}
		}

		public void PrintError(string msg)
		{
			Console.WriteLine(msg);
		}

	}
}
