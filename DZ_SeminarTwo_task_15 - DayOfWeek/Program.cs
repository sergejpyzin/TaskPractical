/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
 */

// Запрашиваем информацию у пользователя
int dayOfWeek;
do
{
    System.Console.Write("Введите номер дня недели: ");
    dayOfWeek = Convert.ToInt32(Console.ReadLine());
} while (dayOfWeek < 1 || dayOfWeek > 7);

// Проверяем условие и выводим информацию
if (dayOfWeek == 6 || dayOfWeek == 7)
    {
        Console.WriteLine($"День недели под номером {dayOfWeek} - выходной");        
    } 
    else
    {
        Console.WriteLine($"День недели под номером {dayOfWeek} - рабочий");
    }