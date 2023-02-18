/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
 */

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
int N = DataRequest("Введите число: ");

Console.WriteLine($"Число\t|  Квадрат");


//  Проводим вычисления
for (int i = 0; i <= N; i++)
{
    double result = Math.Pow(i, 2);
    Console.WriteLine($"{i}\t|\t{result}");
}
