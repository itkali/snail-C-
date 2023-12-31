﻿using System;

namespace Task3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] day = new string[30]; // объявление массива размерности 30 элементов
            Random rnd = new Random(); // подключение рандома

            Console.Write("Введите расстояние в сантиметрах на котором улитка находится от земли: ");
            int ulitka = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите высоту дерева в метрах по которому лезет улитка (оно не должно быть ниже " + ulitka + " сантиметрах): ");
            int tree = Convert.ToInt32(Console.ReadLine());
            tree *= 100; // перевод метры в сантиметры
            if (tree < ulitka)
            {
                Console.Write("Ошибка! Дерево не может быть ниже высоты на котором находится улитка.");
                Environment.Exit(0); // завершение программы
            }

            for (int i = 0; i < day.Length; i++) // цикл заполнения массива рандомными днями
            {
                int value = rnd.Next(0, 2); // рандомная генерация чисел 0,1
                if (value == 0) // если сгенерировалось число 0 - то добалять в массив элемент "солнечный"
                {
                    day[i] = "солнечный"; // добавление элемента "солнечный"
                    ulitka += 2; // улитка подниматся на 2 см.
                    if (ulitka > tree) // проверка что улитка не поднимется выше дерева
                    {
                        Console.Write("\nОшибка! На " + i + " день улитке некуда подниматься.");
                        Environment.Exit(0); // завершение программы
                    }
                }
                else
                {
                    day[i] = "пасмурный"; // иначе "пасмурный"
                    ulitka--; // улитка спускается на 1 см.
                    if (ulitka <= 0) // проверка что улитка не спустилась ниже дерева
                    {
                        Console.Write("\nОшибка! На " + i + " день улитке некуда спускаться.");
                        Environment.Exit(0); // завершение программы
                    }
                }
                Console.Write(day[i]); // вывод всех дней из массива для информативности
                Console.Write(" | "); // для более удобного восприятия информации при выводе
            }
            Console.Write("\nНа 30 день, улитка находится " + ulitka + " сантиметров от земли.");
        }
    }
}
