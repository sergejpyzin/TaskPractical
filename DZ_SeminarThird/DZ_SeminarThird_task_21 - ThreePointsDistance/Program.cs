/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

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
int firstPointcoordinateX = DataRequest("Введите коодинату Х первой точки: ");
int firstPointcoordinateY = DataRequest("Введите коодинату Y первой точки: ");
int firstPointcoordinateZ = DataRequest("Введите коодинату Z первой точки: ");
int secondPointcoordinateX = DataRequest("Введите коодинату Х второй точки: ");
int secondPointcoordinateY = DataRequest("Введите коодинату Y второй точки: ");
int secondPointcoordinateZ = DataRequest("Введите коодинату Z второй точки: ");

// Выполняем решение задачи
double result = Math.Sqrt(Math.Pow(secondPointcoordinateX - firstPointcoordinateX, 2) + Math.Pow(secondPointcoordinateY - firstPointcoordinateY, 2) + Math.Pow(secondPointcoordinateZ - firstPointcoordinateZ, 2));

// Выводим результат
Console.WriteLine($"Расстояние между точками равно - {result:f2}");

