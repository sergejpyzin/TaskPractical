/* Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,10
A (7,-5); B (1,-1) -> 7,21
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
int coordinateXA = DataRequest("Введите координаты точки А по оси Х: ");
int coordinateYA = DataRequest("Введите координаты точки А по оси Y: ");
int coordinateXB = DataRequest("Введите координаты точки B по оси Х: ");
int coordinateYB = DataRequest("Введите координаты точки B по оси Y: ");

// Выполняем вычисления
double distancePoints = Math.Sqrt(Math.Pow(coordinateXB - coordinateXA, 2) + Math.Pow(coordinateYB - coordinateYA, 2));

//Выводим результат
Console.Write($"Расстояние между точками равно {distancePoints:f2}");
