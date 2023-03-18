using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket myTicket = new Ticket(1, "123456", "регулярный", "124", "A1", new DateTime(2023, 3, 20, 12, 0, 0));
            myTicket.GetTimeLeft();
            myTicket.PrintInfo();
            Ticket ticket1 = new Ticket(2, "423423", "регулярный", "123", "A1", new DateTime(2023, 3, 20, 12, 0, 0));
            ticket1.GetTimeLeft();
            ticket1.PrintInfo();
            Ticket ticket2 = new Ticket(3, "654321", "скидочный", "456", "B2", new DateTime(2023, 3, 22, 14, 0, 0));
            ticket2.GetTimeLeft();
            ticket2.PrintInfo();
            Console.ReadKey();
        }
    }
}
