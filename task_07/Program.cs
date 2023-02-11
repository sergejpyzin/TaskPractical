﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Запрашиваем у пользователя информацию
System.Console.WriteLine("Введите любое неоднозначное число. Например 459.");
int number = Convert.ToInt32(Console.ReadLine());

// Находим остаток от деления на 10
int result = number % 10;

// Выводим результат
System.Console.Write("Последнее цифра в заданном числе - ");
System.Console.WriteLine(result);