// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Вариант с вводом чисел пользователем

int[] array = GetArrayFromUser(8);
Console.WriteLine($"{ArrayToString(array)} -> [{ArrayToString(array)}]");

static int[] GetArrayFromUser(int arraySize)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = GetIntFromUser($"Введите элемент массива #{i + 1}: ");
    }
    return array;
}

static string ArrayToString(int[] array)
{
    // 0, 1, 2, 3
    string result = $"{array[0]}";
    for (int i = 1; i < array.Length; i++)
    {
        result = result + $", {array[i]}";
    }
    return result;
}

static int GetIntFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        
        Console.WriteLine("Ошибка ввода!");
    }
}