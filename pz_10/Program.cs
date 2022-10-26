namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите произвольное слово: ");
            string? a = Console.ReadLine(); ;
            Console.Write("Введите произвольное слово: ");
            string? b = Console.ReadLine();

            string aa = String.Concat(a.OrderBy(c => c));
            string bb = String.Concat(b.OrderBy(c => c));

            if (aa == bb)
            {
                Console.WriteLine("Слова являются анаграммой");
            }
            else
            {
                Console.WriteLine("Слова не являются анаграммой");
            }
        }
    }
}