using System;
namespace LogicDasar
{
	public class Logic02Soal06
	{
		public Logic02Soal06()
		{
		}
        public static void CetakData(int n)
        {
            Console.WriteLine("Soal06" + "\n");
            int[] deret = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= 1) deret[j] = 1;
                    else deret[j] = deret[j - 1] + deret[j - 2];

                    if (j >= i && j <= n - i - 1 || j <= i && j >= n - i - 1)
                    {
                        Console.Write(deret[i] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("\n");
        }
    }
}