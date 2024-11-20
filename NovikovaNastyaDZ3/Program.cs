using System;

namespace NovikovaNastyaDZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Упражнение 4.1");
        //Написать программу, которая считает с экрана число от 1 до 365, переводит число в месяц ,и день месяца
            
        string[] monthname = {"январь" ,"февраль","март","апрель","май","июнь", "июль","август","сентябрь","октябрь","ноябрь","декабрь"};
        int[] daysinmonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.WriteLine("Введите номер дня в году от 1 до 365: ");
        if (int.TryParse(Console.ReadLine(), out int dayofYear) && dayofYear >= 1 && dayofYear <= 365)
            {
                int month = 0;
                while (dayofYear > daysinmonth[month])
                {
                    dayofYear -= daysinmonth[month];
                    month++;
                }
                Console.WriteLine($"{dayofYear} {monthname[month]}");
            }
            else
            {
                Console.WriteLine("Ошибка : число должно быть от 1 до 365");
            }
        Console.ReadLine();
        
        Console.WriteLine("Упражнение 4.2");
        //Добавить к задаче из предыдущего упражнения проверку числа, введенного пользователем .Если число меньше 1 или больше 365
        //программа должна вырабатывать исключение и выдавать на экран сообщение

        int[] daysINmonth = { 31, 28,31,30,31, 30,31, 31, 30,31,30, 31 };
        Console.Write("Введите номер дня в году от 1 до 365: ");

            try
            {
                if (!int.TryParse(Console.ReadLine(), out int dayofyear2)) 
                {
                    throw new FormatException("Введено некорректное значение.Введите целое число: ");
                }
                if (dayofyear2 < 1 || dayofyear2 > 365)
                {
                    throw new
        ArgumentOutOfRangeException(nameof(dayofyear2), "Число должно быть от 1 до 365 ");
                }

                int month2 = 0;
                while (dayofyear2 > daysINmonth[month2]) 
                {
                    dayofyear2 -= daysINmonth[month2];
                    month2++;
                }

                Console.WriteLine($"{dayofyear2} {monthname[month2]}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
        Console.ReadLine ();


        Console.WriteLine("Домашнее задание 4.1");
        //В двух верхних программах учитываьб високосный год

        Console.WriteLine("Введите год: ");
        int year;

        while (!int.TryParse(Console.ReadLine(), out year) || year < 1)
        {
            Console.Write("Некорректный ввод. Пожалуйста, введите положительное целое число для года: ");
        }

           
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        if (isLeapYear)
        {
            daysINmonth[1] = 29; // Февраль имеет 29 дней в високосный год
        }

        Console.Write("Введите номер дня в году (от 1 до " + (isLeapYear ? 366 : 365) + "): ");
        int dayOfYear;

            
        while (!int.TryParse(Console.ReadLine(), out dayOfYear) || dayOfYear < 1 || dayOfYear > (isLeapYear ? 366 : 365))
        {
            Console.Write("Некорректный ввод. Пожалуйста, введите целое число от 1 до " + (isLeapYear ? 366 : 365) + ": ");
        }

        int month3 = 0;

           
        while (dayOfYear > daysINmonth[month3])
        {
            dayOfYear -= daysINmonth[month3];
            month3++;
        }

            
        Console.WriteLine($"{dayOfYear} {monthname[month3]} {year} года.");
        Console.ReadLine();


        






























































































        }
    }
}
