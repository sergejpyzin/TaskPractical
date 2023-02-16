/* Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
 */

// Задаем случайное трехзначное число
int number = Random.Shared.Next(100, 1000);
System.Console.WriteLine(number);

// Выполняем условия задачи
int lastDigit = number % 10;
int middleDigit = (number / 10) % 10;
int firstDigit = (number / 100) % 10;
// Console.WriteLine($"{firstDigit} {middleDigit} {lastDigit}");

int resNumber = firstDigit * 10 + lastDigit;

// Выводим результат
System.Console.WriteLine(resNumber);



