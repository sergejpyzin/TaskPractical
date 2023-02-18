/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

// Создаем метод запроса информации у пользователя - DataRequest
int DataRequest(string userMassedge)
{
    while (true)
    {
        try
        {
            Console.Write(userMassedge);
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (System.Exception)
        {

            Console.WriteLine($"Ошибка! Попробуйте еще раз");
            continue;

        }
    }
}

// Запрашиваем информацию у пользователя
int n = DataRequest("Введите число: ");

// Украшаем вывод (я решил упороться в "красоту")
Console.Clear();
Console.WriteLine($"Число\t->  Куб числа");

// Решаем задачу
for (int i = 0; i <= n; i++)
{
    double result = Math.Pow(i, 3);
// Продолжаем украшать :)
    Console.WriteLine($"{i}\t->\t{result}");
}