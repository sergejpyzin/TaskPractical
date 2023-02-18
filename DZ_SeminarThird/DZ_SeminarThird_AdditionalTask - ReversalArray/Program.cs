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

// Создаем метод заполнения массива случайными числами

int [] GetRandomArray (uint length, int minValue, int maxValue)
{
    int [] array = new int [length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(minValue, maxValue);
}
return array;
}

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

// Создаем массив
int value = GetDataRequest("Введите длинну, целое положительное, необходимого массива: ");
int min = GetDataRequest("Введите минимально возможное значение элемента массива: ");
int max = GetDataRequest("Введите максимально возможное значение элемента массива: ");

int [] myArray = GetRandomArray((uint)value, min, max);
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"{myArray[i]} ");    
}

System.Console.WriteLine("\n=============================");

int [] massive = GetReversalArray(myArray);
for (int i = 0; i < massive.Length; i++)
{
    Console.Write($"{massive[i]} ");    
}


