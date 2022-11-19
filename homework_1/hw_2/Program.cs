using System;

namespace hw_2
{
    class Program
    {
        public static string decToBin(int n) //2.1
        {
            string bin = "";

            for (int i = 31; i >= 0; i--) // Перевод в двоичную систему
            {
                int k = n >> i;
                if ((k & 1) == 1)
                    bin += "1";
                else
                    bin += "0";
            }

            string output = "";
            bool flag = false;
            foreach (char c in bin) // Получение числа без лишних нулей
            {
                if (c != '0')
                    flag = true;
                if (flag)
                    output += c;
            }

            return output;
        }

        public static void task2() // 2.2
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int k = m + n;
            
            string binM = decToBin(m);
            string binN = decToBin(n);
            string binK = decToBin(k);

            while (binM.Length != binK.Length)
                binM = '0' + binM;
            while (binN.Length != binK.Length)
                binN = '0' + binN;

            Console.WriteLine(binM);
            Console.WriteLine(binN);
            for (int i = 0; i < binK.Length; i++)
                Console.Write("-");
            Console.WriteLine("");
            Console.WriteLine(binK);

        } 

        public static void task3() // 2.3
        {
            short a = Int16.Parse(Console.ReadLine());
            short b = Int16.Parse(Console.ReadLine());
            short c = Int16.Parse(Console.ReadLine());
            short d = Int16.Parse(Console.ReadLine());

            long l = d << 48 | c << 32 | b << 16 | a << 0;
            Console.WriteLine(l);
        }

        public static void Main(string[] args)
        {
            task3();
        }
    }
}