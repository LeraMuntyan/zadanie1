using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main()
        {
            int i, n, a, j;
            try
            {
                Random rand = new Random();
                Console.WriteLine("vvedite kolichestvo elementov");
                n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                Console.WriteLine("indeksi elementov:");
                for (j = 0; j < n; j++)
                {
                    arr[j]++;
                    Console.Write("{0, 3} ", j);
                }
                Console.WriteLine();
                for (i = 0; i < n; i++)
                {
                    arr[i] = rand.Next(10);

                    Console.Write("{0, 3} ", arr[i]);
                }
                bool f = true;
                for (i = 0; i < n; i++)

                {
                    if (arr[i] == 0)
                    {
                        f = false;
                        Console.WriteLine("\n element ravnii 0 nahoditsa v indekse {0}", i);
                    }
                }
                if (f)
                    Console.WriteLine("\n elementov net");

                Console.WriteLine("Если хотите повторить ввод, введите число 1, если не хотите, то 0");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
            }
            catch
            {
                Console.WriteLine("Если хотите повторить ввод, введите число 1, если не хотите, то 0");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
                return;
            }
            Console.ReadLine();
        }
    }
}



