using System;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задание 2. Определить, расход топлива у пользователя.(1 версия)
            Console.Write("Введите расстояние (в km): ");
            Double dist = Convert.ToDouble(Console.ReadLine());

            Console.Write("Расход топлива (в l): ");
            Double vol = Convert.ToDouble(Console.ReadLine());

            Double cons = (100 * vol) / dist;
            Console.WriteLine($"The car traveled {dist} km, spent {vol} liters of fuel. Average consumption - {cons} liters/100 km");
            Console.ReadLine();
        }
    }
}