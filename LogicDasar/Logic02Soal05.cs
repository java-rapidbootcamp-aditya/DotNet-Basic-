using System;
namespace LogicDasar
{
	public class Logic02Soal05
	{
		public Logic02Soal05()
		{
		}
        public static void CetakData(int n)
        {
            Console.WriteLine("Soal05" + "\n");
            int[] deret = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= 2) deret[j] = 1;
                    else deret[j] = deret[j - 1] + deret[j - 2] + deret[j - 3];

                    if (j >= i && j >= n - i - 1 || j <= i && j <= n - i - 1)
                    {
                        Console.Write(deret[j] + "\t");
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