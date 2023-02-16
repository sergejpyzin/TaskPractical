/* Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

// Запрашиваем информацию у пользователя
System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// Выполняем условия задачи
if (numberA == numberB * numberB)
{
    Console.WriteLine($"Первое число является квадратом второго {numberA}, {numberB}");
    
}
else if (numberB == numberA * numberA)
{
    Console.WriteLine($"Второе число является квадратом первого {numberA}, {numberB}");    
}
else
{
    System.Console.WriteLine("Ни одно число не является квадратом другого");
}