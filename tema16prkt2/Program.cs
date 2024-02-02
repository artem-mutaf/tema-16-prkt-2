using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema16prkt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату вашего рождения: ");
            DateTime time = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Вы родились в данный день недели  ({time.ToString("dddd")})");
            Console.WriteLine($"Ваш порядковый номер дня рождения {time.DayOfYear}");
            if (DateTime.IsLeapYear(time.Year) == true)
            {
                Console.WriteLine("Ваш год является високосным");
            }
            else
            {
                Console.WriteLine("Ваш год не является високосным");
            }
            Console.WriteLine($"{time.ToString("dddd, d MMMM yyyy")}");

            
            
            int age = DateTime.Now.Year - time.Year;
            if (DateTime.Now < time.AddYears(age)) age--;
            Console.WriteLine($"Полный лет - {age}");

            ///сколько дней осталось от сегодняшней даты до вашего ближайшего дня рождения (если день рождения сегодня, то вывести 0)         

            DateTime nextBirthday = new DateTime(DateTime.Now.Year, time.Month, time.Day);
            if(nextBirthday<DateTime.Now)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            int days = (nextBirthday - DateTime.Now).Days;
            WriteLine($"Дней до ближайшего дня рождения - {days}");

            Console.ReadKey();
        }
    }
}
