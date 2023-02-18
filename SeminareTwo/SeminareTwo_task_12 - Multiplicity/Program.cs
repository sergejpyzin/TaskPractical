/* Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

// Запрашиваем информацию у пользователя
System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// Выполняем условия задачи
if (numberA % numberB == 0)
{
    System.Console.WriteLine("Первое число кратное второму");
}
else
{
    int result = numberA % numberB;
    Console.WriteLine($"Первое число не кратно второму, остаток - {result}");
    
}