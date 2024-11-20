using System;

namespace NovikovaNastya3
{
    internal class Program
    {
        enum dayofweek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }


        static void Main(string[] args)
        {
        Console.WriteLine("Задание 1");
        //Написать программу,которая проверяет ,является ли последовательность из 10 чисел упорядоченной по возрастанию

        int[] numbers = new int[10];
        Console.WriteLine("Введите 10 чисел:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool ordered = true;
        int position = -1;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                ordered = false;
                position = i + 2;
                break;
            }
        }

        if (ordered)
        {
            Console.WriteLine("Последовательность упорядочена по возрастанию.");
        }
        else
        {
            Console.WriteLine($"Последовательность не упорядочена. Первое нарушение на позиции: {position}");
        }
        Console.ReadLine();
            
        Console.WriteLine("Задание 2");
        //Игральным картам присвоены порядковые номера в зависимости от их достоинства,остальные соответствуют названию
        //По заданному номеру определить достоинство соответствующей карты

        int k = 0;

        try
        {
            Console.Write("Введите порядковый номер карты (6-14): ");
            k = int.Parse(Console.ReadLine());

     
            if (k < 6 || k > 14)
            {
                throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14.");
            }

                
            string cardValue = GetCardValue(k);
            Console.WriteLine($"Достоинство карты с номером {k}: {cardValue}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите корректное целое число.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Программа завершила выполнение.");
        }
        Console.ReadLine();
    


        string GetCardValue(int number)
        {
            switch (number)
            {
                case 6: return "Шестёрка";
                case 7: return "Семёрка";
                case 8: return "Восьмёрка";
                case 9: return "Девятка";
                case 10: return "Десятка";
                case 11: return "Валет";
                case 12: return "Дама";
                case 13: return "Король";
                case 14: return "Туз";
                default: throw new ArgumentOutOfRangeException();
            
            
            }

 
        }
        Console.WriteLine("Задание 4");
        //написать программу которая в зависимости от порядквого номера дня недели выыводит на экран название

        Console.Write("Введите номер дня недели (1-7): ");

            
        if (int.TryParse(Console.ReadLine(), out int dayNumber))
        {
                
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                    
                dayofweek day = (dayofweek)dayNumber;
                Console.WriteLine($"День недели: {day}");
            }
            else
            {
                Console.WriteLine("Ошибка: Номер дня недели должен быть от 1 до 7.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректный номер.");
        }
        Console.ReadLine();


        Console.WriteLine("Задание 5");


        string[] dolls = { "Hello Kitty", "Barbie doll", "Teddy Bear", "Hello Kitty", "Barbie doll", "Doll House" };


        int bagCount = 0;


        foreach (string doll in dolls)
        {

            if (doll == "Hello Kitty" || doll == "Barbie doll")
            {

                bagCount++;
            }
        }


        Console.WriteLine($"Количество кукол в 'сумке': {bagCount}");
        Console.ReadLine();















        }













    }
}
