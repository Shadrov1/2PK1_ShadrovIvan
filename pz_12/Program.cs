using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int k;
                Console.WriteLine("k: ");
                k = int.Parse(Console.ReadLine());
                DigitCountSum(k, out int c, out int s);
                Console.WriteLine("c: " + c);
                Console.WriteLine("s: " + s);
            }
            Console.ReadKey();
        }
        public static void DigitCountSum(int k, out int c, out int s)
        {
            c = 0;
            s = 0;
            while (k != 0)
            {
                s += k % 10;
                ++c;
                k /= 10;
            }
        }
    }
}