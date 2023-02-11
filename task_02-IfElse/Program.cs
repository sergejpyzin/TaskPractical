// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Запрашиваем информацию у пользователя
Console.Write("Введите номер дня недели: ");
int request = Convert.ToInt32(Console.ReadLine());

// Проверяем условие введенной пользователем информации
if (request == 1) 
{
    Console.WriteLine("Понедельник");
}
else if (request == 2)
{
    Console.WriteLine("Вторник");
}
else if (request == 3)
{
    Console.WriteLine("Среда");
}
else if (request == 4)
{
    Console.WriteLine("Четверг");
}
else if (request == 5)
{
    Console.WriteLine("Пятница");
}
else if (request == 6)
{
    Console.WriteLine("Суббота");
}
else if (request == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
Console.WriteLine("Внимание! Такого дня недели не существует!");
}
