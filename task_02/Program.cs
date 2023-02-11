// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

// Запрашиваем информацию у пользователя
System.Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// Проверяем условие задачи
if (numberA == numberB)
{
    System.Console.WriteLine("Первое число равно второму");
}
else if (numberA > numberB)
{
    System.Console.WriteLine("Минимум равен " + numberB);
    System.Console.WriteLine("Максимум равен " + numberA);
}
else
{
    System.Console.WriteLine("Минимум равен " + numberA);
    System.Console.WriteLine("Максимум равен " + numberB);
}
