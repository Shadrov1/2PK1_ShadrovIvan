namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { -15, -14, -13, -12, -11, -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 14 };
            int max = mas.Max();
            int min = mas.Min();
            if (max >= -min)
                Console.WriteLine("Таких чисел нет!");
            else
            {
                int count = mas.Count(numb => max < -numb);
                Console.WriteLine($"В массиве {count} число больше по модулю максимального");
            }
        }
    }
}