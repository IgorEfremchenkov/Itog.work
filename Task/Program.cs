/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */
    
    // Решение задачи

string[] CreateArray() // создаём массив
{
    System.Console.Write("Введите данные через пробел: ");
    string[] array = Console.ReadLine()!.Split();
    return array;
}

void PrintArray(string[] array) // выводим его на экран
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write(array[i] + "," + " ");
        else System.Console.Write(array[i]);
    }
    System.Console.WriteLine(']');
}

int LengthNewArray(string[] array) // задаем количество элементов массива в соответствии с условием задачи
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] CreateNewArray(string[] array, string[] result) //  новый массив
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

string[] array = CreateArray();
string[] result = new string[LengthNewArray(array)];
result = CreateNewArray(array, result);
PrintArray(result);