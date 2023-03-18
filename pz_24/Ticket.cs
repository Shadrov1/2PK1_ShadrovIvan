using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class Ticket : IClonable
    {
        public int ID;
        public string ownerPassport;
        public string type;
        public string trainNumber;
        public string place;
        public DateTime departureTime;

        public Ticket(int ID, string ownerPassport, string type, string trainNumber, string place, DateTime departureTime)
        {
            this.ID = ID;
            this.ownerPassport = ownerPassport;
            this.type = type;
            this.trainNumber = trainNumber;
            this.place = place;
            this.departureTime = departureTime;
        }

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string OwnerPassport
        {
            get { return ownerPassport; }
            set
            {
                if (value.Length != 6)
                {
                    throw new ArgumentException("Паспорт владельца должен состоять из 6 цифр");
                }
                ownerPassport = value;
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace Указывает, имеет ли указанная строка значение null, 
                                                      // является ли она пустой строкой или строкой, состоящей только из символов-разделителей.
                {
                    throw new ArgumentException("Тип не может быть нулевым или пробельным");
                }
                type = value;
            }
        }

        public string TrainNumber
        {
            get { return trainNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Номер поезда не может быть нулевым или пробельным");
                }
                trainNumber = value;
            }
        }

        public string Place
        {
            get { return place; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Место не может быть нулевым или пробелом");
                }
                place = value;
            }
        }

        public DateTime GetDepartureTime()
        {
            return departureTime;
        }

        public virtual int GetTimeLeft()
        {
            TimeSpan timeLeft = departureTime - DateTime.Now;
            return (int)timeLeft.TotalMinutes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Паспорт владельца: " + ownerPassport);
            Console.WriteLine("Тип: " + type);
            Console.WriteLine("Номер поезда: " + trainNumber);
            Console.WriteLine("Место: " + place);
            Console.WriteLine("Время отправления: " + departureTime);
        }

        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
