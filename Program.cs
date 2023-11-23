// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.Write("Введите количество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
string[] s = new string[n];

void inputArray(string[] array)
{
    int a =1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {a}-й элемент массива");
        s[i] = Convert.ToString(Console.ReadLine()!);
        a++;
    } 
}

string[] sortArray(string[] str)
{
    for (int i = 0; i < n; i++)
    {
        if(str[i].Length <= 3) Console.Write($"{str[i]}, ");
    }
    return str;
}

inputArray(s);
Console.Write($"[{String.Join(", ", s)}]");

Console.Write(" -> [");
sortArray(s);
Console.Write("]");

