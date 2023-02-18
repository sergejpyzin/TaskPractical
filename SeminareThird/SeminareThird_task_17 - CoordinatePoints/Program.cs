/* Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. */

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

// Запрашиваем у пользователя информацию с помощью метода DataRequest
int coordinateX = DataRequest("Введите коодинаты точки по оси Х: ");
int coordinateY = DataRequest("Введите коодинаты точки по оси Y: ");

// Проверяем условия и выдаем результат
if (coordinateX > 0 && coordinateY > 0)
{
    Console.WriteLine($"Точка с координатами {coordinateX}, {coordinateY} находится в первой четверти плоскости");

}
else if (coordinateX < 0 && coordinateY > 0)
{
    Console.WriteLine($"Точка с координатами {coordinateX}, {coordinateY} находится во второй четверти плоскости");

}
else if (coordinateX < 0 && coordinateY < 0)
{
    Console.WriteLine($"Точка с координатами {coordinateX}, {coordinateY} находится в третьей четверти плоскости");

}
else if (coordinateX > 0 && coordinateY < 0)
{
    Console.WriteLine($"Точка с координатами {coordinateX}, {coordinateY} находится в четвертой четверти плоскости");

}
else
{
    Console.WriteLine($"Ошибка! Введенные коодинаты не соответствуют условиям задачи");

}
