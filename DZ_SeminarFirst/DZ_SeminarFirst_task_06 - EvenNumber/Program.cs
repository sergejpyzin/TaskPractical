// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Запрашиваем информацию у пользователя
System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Проверяем введенное число на четность и выдаем решение задачи
if (number % 2 == 0)
{
    System.Console.WriteLine("Да. Число четное");
}
else
{
    System.Console.WriteLine("Нет. Число нечетное");
}