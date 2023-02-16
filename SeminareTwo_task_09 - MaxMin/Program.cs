/* Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */

// Запрашиваем информацию
int number = Random.Shared.Next(10, 100);
System.Console.WriteLine(number);

// Выполняем условие задачи
int lastDigit = number % 10;
int firstDigit = number / 10;

if (firstDigit > lastDigit)
{
    Console.WriteLine($"максимальная цифра - {firstDigit}; минимальная цифра  - {lastDigit}.");
}
else
{
    Console.WriteLine($"максимальная цифра - {lastDigit}; минимальная цифра  - {firstDigit}.");
}