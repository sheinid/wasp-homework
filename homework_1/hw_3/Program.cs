using System;

namespace hw_3
{
    class Program
    {
        public static void task1() // 3.1
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }

            double norm = 0;
            foreach (double elem in arr)
            {
                norm += Math.Pow(elem, p);
            }

            norm = Math.Pow(norm, Math.Pow(p, -1));
            Console.WriteLine(norm);
        }

        public static void task2() // 3.2
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }

            int k = Convert.ToInt32(Console.ReadLine());

            Array.Sort(arr);
            Console.WriteLine(arr[k-1]);
        }

        public static void task3() //3.3
        {
            
        }
        
        public static void Main(string[] args)
        {
            task3();
        }
    }
}