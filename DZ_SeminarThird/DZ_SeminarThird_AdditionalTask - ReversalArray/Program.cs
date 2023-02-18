/* Написать метод для разворота массива, не используя память под дополнительный массив */


// Создаем метод разворота массива ReversalArray

int [] GetReversalArray (int [] array)
{
for (int i = 0, j = array.Length - 1; i < j; i++, j--)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;               
}
return array;
} 

// Проверка работы метода

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

int [] arr = new int [n];

// Заполняем массив
for (int i = 0; i < arr.Length; i++)
{
    arr [i] = DataRequest ("Введите число: ");
}

int [] massive = GetReversalArray(arr);
for (int i = 0; i < massive.Length; i++)
{
    Console.WriteLine($"{massive[i]}");    
}


