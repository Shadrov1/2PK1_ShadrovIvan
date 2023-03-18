using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReturnedTicket myTicket = new ReturnedTicket(1, "1234544", "регулярный", "123", "A1", new DateTime(2023, 3, 20, 12, 0, 0));
            myTicket.GetTimeLeft();
            myTicket.PrintInfo();
            ReturnedTicket ticket1 = new ReturnedTicket(2, "423423", "регулярный", "123", "A1", new DateTime(2023, 3, 20, 12, 0, 0));
            ticket1.GetTimeLeft();
            ticket1.PrintInfo();
            ReturnedTicket ticket2 = new ReturnedTicket(3, "654321", "скидочный", "456", "B2", new DateTime(2023, 3, 22, 14, 0, 0));
            ticket2.GetTimeLeft();
            ticket2.PrintInfo();
            Console.ReadKey();
        }
    }
}
