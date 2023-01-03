using System;
namespace LogicDasar
{
	public class Logic02Soal04
	{
		public Logic02Soal04()
		{
		}
        public static void CetakData(int n)
        {
            Console.WriteLine("Soal04" + "\n");
            int[] deret = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= 1) deret[j] = 1;
                    else deret[j] = deret[j - 1] + deret[j - 2];

                    if (j == 0 || i == 0 || j == n - 1 || i == n - 1 || j == n / 2 || i == n / 2)
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