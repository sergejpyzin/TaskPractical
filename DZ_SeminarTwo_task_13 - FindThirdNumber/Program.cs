/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

// Вводим случайное чмсло
int number = Random.Shared.Next();
System.Console.WriteLine(number);

// Выполняем условия задачи
if (number % 100 == number || number % 10 == number)
{
    System.Console.WriteLine("Данное число не имеет третьего знака");
}
else
{
    do
    {
        if (number % 1000 != number) number = number / 10;
    }
    while (number % 1000 != number);
    number = number % 10;
    System.Console.WriteLine(number);
}
