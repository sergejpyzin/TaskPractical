// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Запрашиваем информацию у пользователя
Console.Write("Введите число (N), где N - целое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Создаем цикл for для обработки информации согласно условию задачи
for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + " ");
}