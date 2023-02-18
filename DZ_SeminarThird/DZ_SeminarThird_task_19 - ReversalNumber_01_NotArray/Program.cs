/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
 */

// Создаем метод запроса информации у пользователя - DataRequest
int GetDataRequest(string userMassedge)
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
int number = GetDataRequest("Введите пятизначное число: ");

int digit1, digit2, digit3, digit4, digit5;
int result;

// Выполняем условия задачи
if (number > 99999 || number < 10000)
{
    System.Console.WriteLine("Ошибка! Данное число не пятизначное.");
}
else
{
    digit5 = number % 10;
    digit4 = number / 10 % 10;
    digit3 = number / 100 % 10;
    digit2 = number / 1000 % 10;
    digit1 = number / 10000;
    result = digit5 * 10000 + digit4 * 1000 + digit3 * 100 + digit2 * 10 + digit1;
    if (result == number)
    {
        Console.WriteLine($"Число {number} является полиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является полиндромом");
        
    }
}

