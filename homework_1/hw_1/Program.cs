using System.Security.Cryptography.X509Certificates;

namespace hw_1
{
    public static class Program
    {
        public static void task1() // 1.1
        {
            int i, j, k, l;

            for (i = 9; i >= 3; i--)
            {
                for (j = i - 1; j >= 2; j--)
                {
                    for (k = j - 1; k >= 1; k--)
                    {
                        for (l = k - 1; l >= 0; l--)
                        {
                            Console.WriteLine(i * 1000 + j * 100 + k * 10 + l);
                        }
                    }
                }
            }
        }

        public static void task2() // 1.2
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            for (int i = n; i > 0; i--)
            {
                m = n - i;
                for (int j = n; j > 0; j--)
                {
                    if (i == j)
                        m = 0;
                    if (m >= n)
                        m = i + 1;
                    if (i + m == j || j + m == i )
                    {
                        Console.Write((n - m) + " ");
                        m++;
                    }
                    else
                    {
                        Console.Write($"{m} ");
                        m++;
                    }
                }
                Console.WriteLine("");
            }
        }

        public static void task3() // 1.4
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int c = 1;
                for (int j = 1; j <= n; j++)
                {
                    if (c != 0)
                        Console.Write(c);
                    c = c * (i - j) / j;
                }
                Console.WriteLine();
            }
        }
        
        public static void Main(string[] args)
        {
            task3();
        }
    }
}