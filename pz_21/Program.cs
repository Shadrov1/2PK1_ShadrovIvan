namespace pz_21
{
internal class Program
    {
        static void Main(string[] args)
        {
            Ticket dt = new Ticket(1236, 43065321, "льготный", 5, 78);
            dt.PrintInfo();
            dt.GetTimeLeft();
            Console.ReadKey();
        }
    }
}