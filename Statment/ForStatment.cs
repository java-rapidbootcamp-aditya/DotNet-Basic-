using System;
namespace Statment
{
	public class ForStatment
	{
		public ForStatment()
		{
		}
		public static void SampleFor()
		{
			Console.WriteLine("Masukan Angka :");
			string? nStr = Console.ReadLine();

			//jika str bernilai null, maka n diberi nilai 0
			//else maka str di conver ke integer

			int n = nStr == null ? 0 : int.Parse(nStr);

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (i == j || i + j == n - 1)
					{
						Console.WriteLine("[" + i + "," + j + "]\t");
					}
					else
					{ 
						Console.Write("\t");
				}
			}
			Console.WriteLine("\n");
		}


		}
	}
}

