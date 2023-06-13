using System;

namespace Proekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine($"Результат:" + result);
            Console.ReadKey();
        }
    }
}