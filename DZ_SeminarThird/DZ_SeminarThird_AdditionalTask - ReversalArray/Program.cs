/* Написать метод для разворота массива, не используя память под дополнительный массив */


// Создаем метод разворота массива ReversalArray

/* int ReversalArray (int array)
{

} */

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

// Создаем массив
int n = DataRequest("Введите длинну массива: ");

int [] array = new int [n];
for (int i = 0; i < n.length; i++)
{
    array [i] = DataRequest ("Введите число: ");
}
for (int j = 0; j < n.length; j++)
{
    Console.WriteLine($"{array [j]}");
    
}