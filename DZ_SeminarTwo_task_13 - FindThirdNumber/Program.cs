﻿/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

// Вводим случайное чмсло
int number = 1000;
int interResult = number % 1000;

// Выполняем условия задачи
for (int i = number; i > int.MaxValue;)
{
    if (number % 1000 != 0)
    {
        number % 10;
    }
}