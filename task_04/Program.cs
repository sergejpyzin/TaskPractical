// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Запрашиваем информацию у пользователя
System.Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

// Вводим переменную max и присваеваем ей значение первого числа
int max = numberA;

// Проверяем условие задачи
if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}

// Выводим решение задачи
System.Console.WriteLine("Максимальное значение равно " + max);
