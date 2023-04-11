using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinese_calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВЫЧИСЛИТЕЛЬ СИМВОЛА ГОДА ПО КИТАЙСКОМУ КАЛЕНДАРЮ\n");
            Console.WriteLine("Введите год, затем нажмите Enter");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 10) == 0) || ((year % 10) == 1))
                Console.Write("\nБелый ");
            else if (((year % 10) == 2) || ((year % 10) == 3))
                Console.Write("\nСиний ");
            else if (((year % 10) == 4) || ((year % 10) == 5))
                Console.Write("\nЗелёный ");
            else if (((year % 10) == 6) || ((year % 10) == 7))
                Console.Write("\nКрасный ");
            else if (((year % 10) == 8) || ((year % 10) == 9))
                Console.Write("\nЖёлтый ");

            year %= 12;
            switch (year)
            {
                case 1: Console.WriteLine("Петух"); break;
                case 2: Console.WriteLine("Собака"); break;
                case 3: Console.WriteLine("Свинья"); break;
                case 4: Console.WriteLine("Мышь"); break;
                case 5: Console.WriteLine("Бык"); break;
                case 6: Console.WriteLine("Тигр"); break;
                case 7: Console.WriteLine("Кролик"); break;
                case 8: Console.WriteLine("Дракон"); break;
                case 9: Console.WriteLine("Змея"); break;
                case 10: Console.WriteLine("Лошадь"); break;
                case 11: Console.WriteLine("Овца"); break;
                case 12: Console.WriteLine("Обезьяна"); break;
                default: Console.WriteLine("ВЫ ОШИБЛИСЬ"); break;
            };

        }
    }
}
