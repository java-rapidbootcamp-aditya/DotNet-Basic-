using System;
namespace LogicDasar
{
    public class Logic02Soal02
    {
        public Logic02Soal02()
        {
        }

        public static void CetakData(int n)
        {
            Console.WriteLine("Soal02" + "\n");
            for (int i = 0; i < n; i++)
            {
                int angka = 1;
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == 0 || i == n - 1 || j == n - 1)
                    {
                        Console.Write(angka + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                    angka += 2;
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("\n");
        }
    }
}
