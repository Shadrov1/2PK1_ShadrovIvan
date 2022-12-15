namespace Pz_18
{
    internal class Enum
    {
        enum Marks
        {
            отлично = 5,
            хорошо = 4,
            удовлетворительно = 3,
            неудовлетворительно = 2,
            очень_плохо = 1
        }
        enum Seasons
        {
            winter,
            spring,
            summer,
            autumn
        }
        static void WriteMarks(int rating)
        {
            switch (rating)
            {
                case 5:
                    Console.WriteLine("Характеристика отметки" + (int)Marks.отлично + ": Отлично");
                    break;
                case 4:
                    Console.WriteLine("Характеристика отметки" + (int)Marks.хорошо + ": Хорошо");
                    break;
                case 3:
                    Console.WriteLine("Характеристика отметки" + (int)Marks.удовлетворительно + ": Удовлетворительно");
                    break;
                case 2:
                    Console.WriteLine("Характеристика отметки" + (int)Marks.неудовлетворительно + ": Неудовлетворительно");
                    break;
                case 1:
                    Console.WriteLine("Характеристика отметки" + (int)Marks.очень_плохо + ": Очень плохо");
                    break;
            }
        }
        static void WriteSeason(string season)
        {
            switch (season)
            {
                case "summer":
                    Console.WriteLine("Праздник в данный промежуток:\n" + " 01.06 Международный день защиты детей в России\n" + " 11.06 День пивовара в России \n" + "12.06 День России\n");
                    break;
                case "winter":
                    Console.WriteLine("Праздники в данный промежуток\n" + "01.01 Новый год\n" + "07.01 Рождество Христово\n" + "16.01 День памяти киборгов\n" + "23.02 День защитника Отечества\n" + "14.12 День обезьян\n");
                    break;
                case "spring":
                    Console.WriteLine("Праздники в данный промежуток\n" + "08.03 8 марта\n" + "01.04 День смеха\n" + "15.04 мой день рождения\n");
                    break;
                case "autumn":
                    Console.WriteLine("Праздники в данный промежуток\n" + "01.09 День знаний\n" + "01.10 Хэллоуин \n" + "06.10 День учителя\n" + "17.11 Международный день студента\n");
                    break;
            }
        }
        static void Main()
        {
            Console.WriteLine("Введите отметку:");
            int rating = Convert.ToInt32(Console.ReadLine());
            WriteMarks(rating);
            Console.WriteLine("Введите время года:");
            string season = Console.ReadLine();
            WriteSeason(season);
        }
    }
}