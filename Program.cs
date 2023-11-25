// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] CreateArray(string[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {count}-й элемент массива: ");
        array[i] = Convert.ToString(Console.ReadLine()!);
        count++;
    }
    return array;
}

void PriintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
        else Console.Write($"\"{arr[i]}\"");
    }
}

string[] SortArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3) Console.Write($"\"{str[i]}\" ");
        
    }
    return str;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
    Console.WriteLine("Некорректный ввод.");
    return;
}
string[] stringArray = new string[n];

CreateArray(stringArray);
Console.Write("[");
PriintArray(stringArray);
Console.Write("]");

Console.Write(" -> [");
SortArray(stringArray);
Console.Write("]");