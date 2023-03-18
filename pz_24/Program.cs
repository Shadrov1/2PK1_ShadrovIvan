using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReturnedTicket myTicket = new ReturnedTicket(1, "1234544", "регулярный", "123", "A1", new DateTime(2023, 3, 20, 12, 0, 0));
            ReturnedTicket myTicketClone = (ReturnedTicket)myTicket.Clone();
            myTicket.GetTimeLeft();
            myTicket.PrintInfo();
            ReturnedTicket ticket1 = new ReturnedTicket(2, "423423", "регулярный", "123", "A1", new DateTime(2023, 3, 20, 12, 0, 0));
            ReturnedTicket Ticket1 = (ReturnedTicket)ticket1.Clone();
            ticket1.GetTimeLeft();
            ticket1.PrintInfo();
            ReturnedTicket ticket2 = new ReturnedTicket(3, "654321", "скидочный", "456", "B2", new DateTime(2023, 3, 22, 14, 0, 0));
            ReturnedTicket Ticket2 = (ReturnedTicket)ticket2.Clone();
            ticket2.GetTimeLeft();
            ticket2.PrintInfo();
            myTicket.ID = 66;
            ticket1.ID = 33;
            ticket2.ID = 11;
            Console.WriteLine($"\nклонированные объекты остались без изменений 1: {myTicketClone.ID}\nклонированные объекты остались без изменений 2: {Ticket1.ID}\nклонированные объекты остались без изменений 3: {Ticket2.ID}\n");
            Console.WriteLine($"клонированные объекты c изменениями 1: {myTicket.ID}\nклонированные объекты c изменениями 2: {ticket1.ID}\nклонированные объекты c изменениями 3: {ticket2.ID}\n");
            
            Console.ReadKey();
        }
    }
}
