namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t = 0;
            double g = 9.8;
            while (true)
            {
                t += 0.5;
                double v = g * t;
                Console.WriteLine(v);
            }
                
        }
    }
}