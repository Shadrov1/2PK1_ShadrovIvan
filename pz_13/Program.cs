using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ваш рост (cм.)?");
            double rost = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ваш вес (кг.)?");
            double ves = Double.Parse(Console.ReadLine());

            double imt = (ves / (rost * rost))*10000;

            Console.WriteLine("Ваш индекс массы тела: " + imt);
            Console.ReadLine();
            //var 24
        }
    }
}
