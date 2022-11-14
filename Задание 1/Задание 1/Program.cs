using System;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Определить и вычислить, является ли веденным пользователем год високосным или не високосным.
            Console.Write("Введите любой год: ");
            int year = int.Parse(Console.ReadLine());
            string output = null;

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        output = "високосный год";

                    else
                        output = "не високосный год";
                }
                else
                    output = "високосный год";
            }
            else
                output = "не високосный год";

            Console.WriteLine($"Год {year} является - {output}");
            Console.ReadLine();
        }
    }
}