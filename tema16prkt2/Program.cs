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

            DateTime date = DateTime.Now;
            Console.WriteLine($"{date.Year - date.Month - time.Year}");


            //Console.WriteLine($"\nРазница между датами в {date.Subtract(time)} дней\n");





            Console.ReadKey();
        }
    }
}
