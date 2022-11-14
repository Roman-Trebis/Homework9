using System;

namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задание 3.
            var FibNumbers = new List<int> { 0, 1, 2, 3, 5, 8, 13 };
            foreach (int elements in FibNumbers)
            {
                Console.WriteLine($"{elements}");
            }

            int n, i, sum = 0;
            Console.Write("Enter a positive integer: ");
            n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; ++i)
            //{
            //sum += i;
            //}

            i = 1;
            while (i <= n)
            {
                sum += i;
                ++i;
            }

            Console.WriteLine($"Sum = {sum}");
            Console.ReadLine();
        }
    }
}