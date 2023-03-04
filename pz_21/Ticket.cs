using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pz_21
{
    internal class Ticket
    {
        public int ID { get; set; }
        public int OwnerPassport { get; set; }
        public string Type { get; set; }
        public int TrainNumber { get; set; }
        public int Place { get; set; }
        public DateTime DepartureTime;

        public Ticket(int iD, int ownerPassport, string type, int trainNumber, int place)

        {
            ID = iD;
            OwnerPassport = ownerPassport;
            Type = type;
            TrainNumber = trainNumber;
            Place = place;
        }
        public void PrintInfo()
        {
            var Date1 = new DateTime(2023, 2, 2, 11, 40, 00);
            Console.WriteLine($"ID: {ID}\n" +
            $"Номер паспорта: {OwnerPassport}\n" +
            $"Категория билета: {Type}\n" +
            $"Номер поезда: {TrainNumber}\n" +
            $"Место: {Place}\n" +
            $"Время отправления поезда: {Date1}");
        }
        public void GetTimeLeft()
        {
            var Date = new DateTime(2023, 2, 2, 11, 40, 00);
            DateTime dateTime = DateTime.Now;
            TimeSpan timeLeft = DateTime.Now - Date;
            Console.WriteLine($"Оставшееся время в минутах: {timeLeft.TotalMinutes}");
        }
    }
}
