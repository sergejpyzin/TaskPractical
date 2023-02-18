/* Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y). */

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

// Запрашиваем у пользователя информацию
int numberQuarted = DataRequest("Введите номер четверти координатной плоскости: ");

// Проверяем условия и выдаем результат
switch (numberQuarted)
{
    case 1:
        Console.WriteLine($"Точка в данной  четверти имеет координаты x > 0 && y > 0");
        break;
    case 2:
        Console.WriteLine($"Точка в данной  четверти имеет координаты x < 0 && y > 0");
        break;
    case 3:
        Console.WriteLine($"Точка в данной  четверти имеет координаты x < 0 && y < 0");
        break;
    case 4:
        Console.WriteLine($"Точка в данной  четверти имеет координаты x > 0 && y < 0");
        break;
    default:
        Console.WriteLine($"Ошибка! Номер введенной четверти плоскости не существует");
        break;
}


