﻿using System;
class Program
{


    static void Main()
    {


        Console.Write("Введіть перше число: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int number2 = int.Parse(Console.ReadLine());

        bool isDay = 1 <= number1 && number1 <= 31;
        bool isMonth = 1 <= number2 && number2 <= 12;

        if (isDay && isMonth)
        {
            Console.WriteLine($"{number1} днем і {number2} місяць");
        }
        else
        {
            Console.WriteLine($"{number1} і {number2} ці числа не підходять");
        }



        //3




        Console.Write("Яка година: ");
        int h = Convert.ToInt32(Console.ReadLine());

        string time;

        if (h >= 4 && h < 12)
        {
            time = "Доброго ранку!";
        }
        else if (h >= 12 && h < 17)
        {
            time = "Добрий день!";
        }
        else if (h >= 17 && h < 21)
        {
            time = "Добрий вечір!";
        }
        else
        {
            time = "Доброї ночі!";
        }

        Console.WriteLine(time);

        //4
        int num1, num2, num3;

        Console.Write("перше число: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("друге число: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("третє число: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        int max = Math.Max(Math.Max(num1, num2), num3);
        int min = Math.Min(Math.Min(num1, num2), num3);

        Console.WriteLine(max);
        Console.WriteLine(min);


        //6

        Console.Write("Введіть ціле число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine(" число є парним.");
        }
        else
        {
            Console.WriteLine(" число є непарним.");
        }

        //7

        Console.Write("температуру в градусах Цельсія: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit} F");

        //8

        Console.Write("Введіть n");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сума перших {n} натуральних чисел дорівнює {sum}");
    }

}