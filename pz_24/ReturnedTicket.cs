using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class ReturnedTicket : Ticket, IClonable
    {
        private DateTime reservationDate; // дата бронирования следующего рейса

        public ReturnedTicket(int id, string ownerPassport, string type, string trainNumber, string place, DateTime departureTime)
            : base(id, ownerPassport, type, trainNumber, place, departureTime)
        {
            reservationDate = new DateTime(); // по умолчанию бронь отсутствует
        }

        public void CreateReservation()
        {
            reservationDate = departureTime.AddDays(1); // бронируем следующий день после отправления
            Console.WriteLine("Бронь создана на {0:d}", reservationDate);
        }

        public virtual int GetTimeLeft()
        {
            TimeSpan timeLeft = departureTime.Subtract(DateTime.Now);
            return (int)timeLeft.TotalMinutes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("ID билета: {0}", ID);
            Console.WriteLine("Номер паспорта владельца: {0}", OwnerPassport);
            Console.WriteLine("Категория билета: {0}", Type);
            Console.WriteLine("Номер поезда: {0}", TrainNumber);
            Console.WriteLine("Место: {0}", Place);
            Console.WriteLine("Время отправления: {0}", departureTime);
            if (reservationDate != new DateTime())
            {
                Console.WriteLine("Дата бронирования следующего рейса: {0:d}", reservationDate);
            }
        }

        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
