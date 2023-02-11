// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int square = numberB * numberB;

if (numberA == square)
{
    Console.WriteLine("Да. Первое число являеться квадратом второго");
}
else 
{
    Console.WriteLine("Нет. Первое число не являеться квадратом второго");
}